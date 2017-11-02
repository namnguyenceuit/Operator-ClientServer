using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCTNC
{
    public partial class Client : Form
    {
        /*Declare data structure*/
        //Create a TCPClient for connecting to server
        TcpClient client;
        //Stream for sending and receiving data
        Stream stream;

        //byte type array for storing byte type data
        byte[] dataIn;
        byte[] dataOut;

        /*-----------------------------------------*/

        public Client()
        {
            InitializeComponent();
            Plus_Button.Enabled = false;
            Sub_Button.Enabled = false;
            Mul_Button.Enabled = false;
            Div_Button.Enabled = false;
        }

        private void Client_Load(object sender, EventArgs e) => CheckForIllegalCrossThreadCalls = false;

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            Client_Init();

            Thread receivingData = new Thread(ReceivingData);
            receivingData.Start();
        }

        private void Client_Init()
        {
            try
            {
                string ipAd = ipAdTextBox.Text;
                int port = int.Parse(portTextBox.Text);

                //connect to server
                client = new TcpClient(ipAd, port);

                //get stream for receiving and sending data
                stream = client.GetStream();

                ButtonConnect.Enabled = false;

                Plus_Button.Enabled = true;
                Sub_Button.Enabled = true;
                Mul_Button.Enabled = true;
                Div_Button.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Wrong Ip/Port or Server did't start yet, cannot init client!");
            }
        }

        private void ReceivingData()
        {
            while (true)
            {
                try
                {
                    string result = null;
                    dataIn = new byte[100];

                    //receive data form server
                    int k = stream.Read(dataIn, 0, 100);

                    //convert
                    for (int i = 0; i < k; i++)
                        result += Convert.ToChar(dataIn[i]);

                    dataReceiveTextBox.Text = result;
                }
                catch
                {
                    break;
                }
            }
        }

        /*process send data & kind of calculation to server*/


        private void SendingData(String str)
        {
            try
            {
                ASCIIEncoding asen = new ASCIIEncoding();

                //encoding to bytes
                dataOut = asen.GetBytes(str);
                stream.Write(dataOut, 0, dataOut.Length);
            }
            catch
            {
                MessageBox.Show("Cannot send data!");
            }
        }

        private void Plus_Button_Click(object sender, EventArgs e)
        {
            if (!IsInputEmpty())
                return;

            string str = null;
            str = num1TextBox.Text + "+" + num2TextBox.Text;

            SendingData(str);
        }

        private void Sub_Button_Click(object sender, EventArgs e)
        {
            if (!IsInputEmpty())
                return;

            string str = null;
            str = num1TextBox.Text + "-" + num2TextBox.Text;

            SendingData(str);
        }

        private void Mul_Button_Click(object sender, EventArgs e)
        {
            if (!IsInputEmpty())
                return;

            string str = null;
            str = num1TextBox.Text + "*" + num2TextBox.Text;

            SendingData(str);
        }

        private void Div_Button_Click(object sender, EventArgs e)
        {
            if (!IsInputEmpty())
                return;

            string str = null;
            str = num1TextBox.Text + "/" + num2TextBox.Text;

            SendingData(str);
        }

        bool IsInputEmpty()
        {
            if (num1TextBox.Text == "")
            {
                MessageBox.Show("Please input the first number!");
                num1TextBox.Focus();

                return false;
            }

            if (num2TextBox.Text == "")
            {
                MessageBox.Show("Please input the second number!");
                num2TextBox.Focus();

                return false;
            }
            return true;
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                client.Close();
            }
            catch
            {
                //do nothing
            }
        }
    }
}
