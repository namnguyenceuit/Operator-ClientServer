namespace ClientCTNC
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataReceiveTextBox = new System.Windows.Forms.TextBox();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipAdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Plus_Button = new System.Windows.Forms.Button();
            this.Sub_Button = new System.Windows.Forms.Button();
            this.Div_Button = new System.Windows.Forms.Button();
            this.Mul_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataReceiveTextBox
            // 
            this.dataReceiveTextBox.Location = new System.Drawing.Point(210, 167);
            this.dataReceiveTextBox.Name = "dataReceiveTextBox";
            this.dataReceiveTextBox.ReadOnly = true;
            this.dataReceiveTextBox.Size = new System.Drawing.Size(118, 20);
            this.dataReceiveTextBox.TabIndex = 42;
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(76, 89);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(128, 20);
            this.num1TextBox.TabIndex = 41;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(228, 11);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 49);
            this.ButtonConnect.TabIndex = 40;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(76, 40);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(128, 20);
            this.portTextBox.TabIndex = 39;
            this.portTextBox.Text = "13000";
            // 
            // ipAdTextBox
            // 
            this.ipAdTextBox.Location = new System.Drawing.Point(76, 11);
            this.ipAdTextBox.Name = "ipAdTextBox";
            this.ipAdTextBox.Size = new System.Drawing.Size(128, 20);
            this.ipAdTextBox.TabIndex = 38;
            this.ipAdTextBox.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Kết quả tính toán trả về từ Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Địa chỉ IP";
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(76, 124);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(128, 20);
            this.num2TextBox.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Số thứ hai";
            // 
            // Plus_Button
            // 
            this.Plus_Button.Location = new System.Drawing.Point(210, 87);
            this.Plus_Button.Name = "Plus_Button";
            this.Plus_Button.Size = new System.Drawing.Size(51, 23);
            this.Plus_Button.TabIndex = 45;
            this.Plus_Button.Text = "+";
            this.Plus_Button.UseVisualStyleBackColor = true;
            this.Plus_Button.Click += new System.EventHandler(this.Plus_Button_Click);
            // 
            // Sub_Button
            // 
            this.Sub_Button.Location = new System.Drawing.Point(277, 87);
            this.Sub_Button.Name = "Sub_Button";
            this.Sub_Button.Size = new System.Drawing.Size(51, 23);
            this.Sub_Button.TabIndex = 49;
            this.Sub_Button.Text = "-";
            this.Sub_Button.UseVisualStyleBackColor = true;
            this.Sub_Button.Click += new System.EventHandler(this.Sub_Button_Click);
            // 
            // Div_Button
            // 
            this.Div_Button.Location = new System.Drawing.Point(277, 122);
            this.Div_Button.Name = "Div_Button";
            this.Div_Button.Size = new System.Drawing.Size(51, 23);
            this.Div_Button.TabIndex = 51;
            this.Div_Button.Text = "/";
            this.Div_Button.UseVisualStyleBackColor = true;
            this.Div_Button.Click += new System.EventHandler(this.Div_Button_Click);
            // 
            // Mul_Button
            // 
            this.Mul_Button.Location = new System.Drawing.Point(210, 122);
            this.Mul_Button.Name = "Mul_Button";
            this.Mul_Button.Size = new System.Drawing.Size(51, 23);
            this.Mul_Button.TabIndex = 50;
            this.Mul_Button.Text = "*";
            this.Mul_Button.UseVisualStyleBackColor = true;
            this.Mul_Button.Click += new System.EventHandler(this.Mul_Button_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 198);
            this.Controls.Add(this.Div_Button);
            this.Controls.Add(this.Mul_Button);
            this.Controls.Add(this.Sub_Button);
            this.Controls.Add(this.Plus_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.dataReceiveTextBox);
            this.Controls.Add(this.num1TextBox);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipAdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dataReceiveTextBox;
        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox ipAdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Plus_Button;
        private System.Windows.Forms.Button Sub_Button;
        private System.Windows.Forms.Button Div_Button;
        private System.Windows.Forms.Button Mul_Button;
    }
}

