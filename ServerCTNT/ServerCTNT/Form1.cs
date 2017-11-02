using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerCTNT
{
    public partial class Server : Form
    {
        /*Declare data structure*/
        TcpListener server;
        IPAddress ipAd;
        Socket[] socket;
        int port;

        byte[] dataIn = new byte[100];
        byte[] dataOut;
        
        /*----------------*/

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e) => CheckForIllegalCrossThreadCalls = false;

        private void StartButton_Click(object sender, EventArgs e)
        {
            Server_Init();

            Thread showAcceptedConnection = new Thread(Show_AcceptedConnection);
            showAcceptedConnection.Start();
        }

        /*Init Server*/
        private void Server_Init()
        {
            //Data structure
            socket = new Socket[100];
            ipAd = IPAddress.Parse(ipAdTextBox.Text);
            port = int.Parse(portTextBox.Text);
            server = new TcpListener(ipAd, port);

            //listen
            server.Start();
            StartButton.Enabled = false;
        }
        /*------------------------------*/

        private void Show_AcceptedConnection(object obj)
        {
            int count = 0;
            
            //server multiple clients
            while(true)
            {
                try
                {
                    //accept a new connection
                    socket[count] = server.AcceptSocket();
                    connectionManagerTextBox.AppendText("Connection accepted from client " + count + " "
                        + socket[count].RemoteEndPoint + Environment.NewLine);

                    Thread showDataFromClient = new Thread(Show_DataFromClient);
                    showDataFromClient.Start(count);

                    count++;
                }
                catch
                {
                    break;
                }
            }
        }

        //receive data from client
        private void Show_DataFromClient(object obj)
        {
            while(true)
            {
                int count = (int)obj;
                try
                {
                    string result = null;

                    //length of message
                    int k = socket[count].Receive(dataIn);
                    clientCommunicationTextBox.AppendText("From client: " + count + Environment.NewLine);

                    for (int i = 0; i < k; i++)
                        result += Convert.ToChar(dataIn[i]);

                    clientCommunicationTextBox.AppendText(result + Environment.NewLine);

                    String_Process(result, count);

                    
                }
                catch
                {
                    break;
                }
            }
        }

        //split the string to get the exactly operator & operand
        private void String_Process(string str, int count)
        {
            /*---------------Get the operator------------------*/
            char operatoR = ' ';

            //declare to use for other elements
            int i;

            for (i = 0; i < str.Length; i++)
            {
                if ((str[i] == '+') || (str[i] == '-') || (str[i] == '*') || (str[i] == '/'))
                {
                    operatoR = str[i];

                    break;
                }
            }
            /*---------------------------------------------------------------------------*/

            //num array store splited number
            string[] num = new string[2];

            //substring will be cut from 0->i
            num[0] = str.Substring(0, i);
            //substring will be cut from i+1 -> last character(except the operator)
            num[1] = str.Substring(i + 1);

            //Cal the result
            int result = Calculate(num, operatoR);

            //Send back to client
            try
            {
                ASCIIEncoding asen = new ASCIIEncoding();
                dataOut = asen.GetBytes(result.ToString());

                socket[count].Send(dataOut);
            }
            catch
            {
                MessageBox.Show("Can't calculate!");
            }

        }

        private int Calculate(string [] str, char operatoR)
        {
            int result = 0;

            //parse to int
            int num1 = int.Parse(str[0]);
            int num2 = int.Parse(str[1]);

            switch(operatoR)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    break;
            }

            return result;
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                server.Stop();
            }
            catch
            {
                //do nothing
            }
        }
    }
}
