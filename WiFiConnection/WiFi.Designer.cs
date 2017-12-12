namespace WiFiNetworks
{
    partial class WiFi
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
            this.components = new System.ComponentModel.Container();
            this.NetworkList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BssId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsSecured = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsConnected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectionB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordF = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UrlF = new System.Windows.Forms.TextBox();
            this.PingB = new System.Windows.Forms.Button();
            this.PingAnswer = new System.Windows.Forms.TextBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NetworkList
            // 
            this.NetworkList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.Description,
            this.BssId,
            this.IsSecured,
            this.IsConnected});
            this.NetworkList.FullRowSelect = true;
            this.NetworkList.Location = new System.Drawing.Point(16, 15);
            this.NetworkList.Margin = new System.Windows.Forms.Padding(4);
            this.NetworkList.MultiSelect = false;
            this.NetworkList.Name = "NetworkList";
            this.NetworkList.Size = new System.Drawing.Size(716, 246);
            this.NetworkList.TabIndex = 0;
            this.NetworkList.UseCompatibleStateImageBehavior = false;
            this.NetworkList.View = System.Windows.Forms.View.Details;
            this.NetworkList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NetworkList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Signal strength";
            this.columnHeader2.Width = 55;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 77;
            // 
            // BssId
            // 
            this.BssId.Text = "BssId";
            this.BssId.Width = 121;
            // 
            // IsSecured
            // 
            this.IsSecured.Text = "IsSecured";
            // 
            // IsConnected
            // 
            this.IsConnected.Text = "IsConnected";
            // 
            // ConnectionB
            // 
            this.ConnectionB.Location = new System.Drawing.Point(524, 272);
            this.ConnectionB.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectionB.Name = "ConnectionB";
            this.ConnectionB.Size = new System.Drawing.Size(100, 25);
            this.ConnectionB.TabIndex = 2;
            this.ConnectionB.Text = "Connect";
            this.ConnectionB.UseVisualStyleBackColor = true;
            this.ConnectionB.Click += new System.EventHandler(this.ConnectionB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // PasswordF
            // 
            this.PasswordF.Location = new System.Drawing.Point(95, 273);
            this.PasswordF.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordF.Name = "PasswordF";
            this.PasswordF.PasswordChar = '*';
            this.PasswordF.Size = new System.Drawing.Size(421, 22);
            this.PasswordF.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UrlF
            // 
            this.UrlF.Location = new System.Drawing.Point(95, 305);
            this.UrlF.Margin = new System.Windows.Forms.Padding(4);
            this.UrlF.Name = "UrlF";
            this.UrlF.Size = new System.Drawing.Size(530, 22);
            this.UrlF.TabIndex = 6;
            // 
            // PingB
            // 
            this.PingB.Location = new System.Drawing.Point(633, 305);
            this.PingB.Margin = new System.Windows.Forms.Padding(4);
            this.PingB.Name = "PingB";
            this.PingB.Size = new System.Drawing.Size(100, 25);
            this.PingB.TabIndex = 7;
            this.PingB.Text = "Ping";
            this.PingB.UseVisualStyleBackColor = true;
            this.PingB.Click += new System.EventHandler(this.PingB_Click);
            // 
            // PingAnswer
            // 
            this.PingAnswer.Location = new System.Drawing.Point(16, 337);
            this.PingAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.PingAnswer.Multiline = true;
            this.PingAnswer.Name = "PingAnswer";
            this.PingAnswer.Size = new System.Drawing.Size(716, 128);
            this.PingAnswer.TabIndex = 8;
            // 
            // Disconnect
            // 
            this.Disconnect.Enabled = false;
            this.Disconnect.Location = new System.Drawing.Point(632, 273);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(100, 25);
            this.Disconnect.TabIndex = 9;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "URL";
            // 
            // WiFi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.PingAnswer);
            this.Controls.Add(this.PingB);
            this.Controls.Add(this.UrlF);
            this.Controls.Add(this.PasswordF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectionB);
            this.Controls.Add(this.NetworkList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WiFi";
            this.Text = "WiFi";
            this.Load += new System.EventHandler(this.WiFi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView NetworkList;
        private System.Windows.Forms.Button ConnectionB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordF;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox UrlF;
        private System.Windows.Forms.Button PingB;
        private System.Windows.Forms.TextBox PingAnswer;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader BssId;
        private System.Windows.Forms.ColumnHeader IsSecured;
        private System.Windows.Forms.ColumnHeader IsConnected;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Label label2;
    }
}

