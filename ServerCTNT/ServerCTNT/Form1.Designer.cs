namespace ServerCTNT
{
    partial class Server
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
            this.clientCommunicationTextBox = new System.Windows.Forms.TextBox();
            this.connectionManagerTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipAdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientCommunicationTextBox
            // 
            this.clientCommunicationTextBox.Location = new System.Drawing.Point(13, 232);
            this.clientCommunicationTextBox.Multiline = true;
            this.clientCommunicationTextBox.Name = "clientCommunicationTextBox";
            this.clientCommunicationTextBox.ReadOnly = true;
            this.clientCommunicationTextBox.Size = new System.Drawing.Size(264, 84);
            this.clientCommunicationTextBox.TabIndex = 45;
            // 
            // connectionManagerTextBox
            // 
            this.connectionManagerTextBox.Location = new System.Drawing.Point(12, 104);
            this.connectionManagerTextBox.Multiline = true;
            this.connectionManagerTextBox.Name = "connectionManagerTextBox";
            this.connectionManagerTextBox.ReadOnly = true;
            this.connectionManagerTextBox.Size = new System.Drawing.Size(265, 81);
            this.connectionManagerTextBox.TabIndex = 44;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(203, 10);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 49);
            this.StartButton.TabIndex = 43;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(69, 39);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(128, 20);
            this.portTextBox.TabIndex = 42;
            this.portTextBox.Text = "13000";
            // 
            // ipAdTextBox
            // 
            this.ipAdTextBox.Location = new System.Drawing.Point(69, 10);
            this.ipAdTextBox.Name = "ipAdTextBox";
            this.ipAdTextBox.Size = new System.Drawing.Size(128, 20);
            this.ipAdTextBox.TabIndex = 41;
            this.ipAdTextBox.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Quản lí giao tiếp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Quản lí kết nối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Địa chỉ IP";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 331);
            this.Controls.Add(this.clientCommunicationTextBox);
            this.Controls.Add(this.connectionManagerTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipAdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientCommunicationTextBox;
        private System.Windows.Forms.TextBox connectionManagerTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox ipAdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

