namespace Daniels_LightTestApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_runtest = new System.Windows.Forms.Button();
            this.label_lightsensor_baudrate = new System.Windows.Forms.Label();
            this.lightsensor_baudrate_db = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lightsensor_databits_db = new System.Windows.Forms.ComboBox();
            this.lightsensor_parity_label = new System.Windows.Forms.Label();
            this.lightsensor_parity_db = new System.Windows.Forms.ComboBox();
            this.comport_dc = new System.Windows.Forms.Button();
            this.lft_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.dwn_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_runtest
            // 
            this.btn_runtest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_runtest.Location = new System.Drawing.Point(12, 157);
            this.btn_runtest.Name = "btn_runtest";
            this.btn_runtest.Size = new System.Drawing.Size(64, 23);
            this.btn_runtest.TabIndex = 0;
            this.btn_runtest.Text = "&Run Test";
            this.btn_runtest.UseVisualStyleBackColor = false;
            this.btn_runtest.Click += new System.EventHandler(this.btn_runtest_Click);
            // 
            // label_lightsensor_baudrate
            // 
            this.label_lightsensor_baudrate.AutoSize = true;
            this.label_lightsensor_baudrate.Location = new System.Drawing.Point(9, 56);
            this.label_lightsensor_baudrate.Name = "label_lightsensor_baudrate";
            this.label_lightsensor_baudrate.Size = new System.Drawing.Size(112, 13);
            this.label_lightsensor_baudrate.TabIndex = 1;
            this.label_lightsensor_baudrate.Text = "Light Sensor Baudrate";
            // 
            // lightsensor_baudrate_db
            // 
            this.lightsensor_baudrate_db.AllowDrop = true;
            this.lightsensor_baudrate_db.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lightsensor_baudrate_db.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightsensor_baudrate_db.FormattingEnabled = true;
            this.lightsensor_baudrate_db.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.lightsensor_baudrate_db.Location = new System.Drawing.Point(127, 53);
            this.lightsensor_baudrate_db.Name = "lightsensor_baudrate_db";
            this.lightsensor_baudrate_db.Size = new System.Drawing.Size(84, 21);
            this.lightsensor_baudrate_db.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Light Sensor Databits";
            // 
            // lightsensor_databits_db
            // 
            this.lightsensor_databits_db.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lightsensor_databits_db.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightsensor_databits_db.FormattingEnabled = true;
            this.lightsensor_databits_db.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.lightsensor_databits_db.Location = new System.Drawing.Point(127, 80);
            this.lightsensor_databits_db.Name = "lightsensor_databits_db";
            this.lightsensor_databits_db.Size = new System.Drawing.Size(84, 21);
            this.lightsensor_databits_db.TabIndex = 4;
            // 
            // lightsensor_parity_label
            // 
            this.lightsensor_parity_label.AutoSize = true;
            this.lightsensor_parity_label.Location = new System.Drawing.Point(9, 110);
            this.lightsensor_parity_label.Name = "lightsensor_parity_label";
            this.lightsensor_parity_label.Size = new System.Drawing.Size(95, 13);
            this.lightsensor_parity_label.TabIndex = 6;
            this.lightsensor_parity_label.Text = "Light Sensor Parity";
            // 
            // lightsensor_parity_db
            // 
            this.lightsensor_parity_db.AllowDrop = true;
            this.lightsensor_parity_db.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lightsensor_parity_db.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightsensor_parity_db.FormattingEnabled = true;
            this.lightsensor_parity_db.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.lightsensor_parity_db.Location = new System.Drawing.Point(127, 107);
            this.lightsensor_parity_db.Name = "lightsensor_parity_db";
            this.lightsensor_parity_db.Size = new System.Drawing.Size(84, 21);
            this.lightsensor_parity_db.TabIndex = 7;
            // 
            // comport_dc
            // 
            this.comport_dc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comport_dc.Location = new System.Drawing.Point(93, 10);
            this.comport_dc.Name = "comport_dc";
            this.comport_dc.Size = new System.Drawing.Size(75, 23);
            this.comport_dc.TabIndex = 8;
            this.comport_dc.Text = "&Disconnect";
            this.comport_dc.UseVisualStyleBackColor = false;
            this.comport_dc.Click += new System.EventHandler(this.comport_dc_Click);
            // 
            // lft_btn
            // 
            this.lft_btn.Image = global::Daniels_LightTestApplication.Properties.Resources.lft_arrow;
            this.lft_btn.Location = new System.Drawing.Point(248, 67);
            this.lft_btn.Name = "lft_btn";
            this.lft_btn.Size = new System.Drawing.Size(37, 37);
            this.lft_btn.TabIndex = 12;
            this.lft_btn.UseVisualStyleBackColor = true;
            this.lft_btn.Click += new System.EventHandler(this.lft_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.Image = global::Daniels_LightTestApplication.Properties.Resources.rght_arrow;
            this.right_btn.Location = new System.Drawing.Point(355, 67);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(37, 37);
            this.right_btn.TabIndex = 11;
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // up_btn
            // 
            this.up_btn.Image = global::Daniels_LightTestApplication.Properties.Resources.up_arrow1;
            this.up_btn.Location = new System.Drawing.Point(301, 26);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(37, 37);
            this.up_btn.TabIndex = 10;
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // dwn_btn
            // 
            this.dwn_btn.Image = ((System.Drawing.Image)(resources.GetObject("dwn_btn.Image")));
            this.dwn_btn.Location = new System.Drawing.Point(301, 110);
            this.dwn_btn.Name = "dwn_btn";
            this.dwn_btn.Size = new System.Drawing.Size(37, 37);
            this.dwn_btn.TabIndex = 9;
            this.dwn_btn.UseVisualStyleBackColor = true;
            this.dwn_btn.Click += new System.EventHandler(this.dwn_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(291, 69);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(58, 32);
            this.home_btn.TabIndex = 13;
            this.home_btn.Text = "HOME";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.connect_btn.Location = new System.Drawing.Point(12, 10);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 14;
            this.connect_btn.Text = "&Connect";
            this.connect_btn.UseVisualStyleBackColor = false;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Location = new System.Drawing.Point(12, 186);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(384, 99);
            this.Output.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(413, 324);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.lft_btn);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.up_btn);
            this.Controls.Add(this.dwn_btn);
            this.Controls.Add(this.comport_dc);
            this.Controls.Add(this.lightsensor_parity_db);
            this.Controls.Add(this.lightsensor_parity_label);
            this.Controls.Add(this.lightsensor_databits_db);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightsensor_baudrate_db);
            this.Controls.Add(this.label_lightsensor_baudrate);
            this.Controls.Add(this.btn_runtest);
            this.Name = "MainForm";
            this.Text = "Light Test Application";
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_runtest;
        private System.Windows.Forms.Label label_lightsensor_baudrate;
        private System.Windows.Forms.ComboBox lightsensor_baudrate_db;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lightsensor_databits_db;
        private System.Windows.Forms.Label lightsensor_parity_label;
        private System.Windows.Forms.ComboBox lightsensor_parity_db;
        private System.Windows.Forms.Button comport_dc;
        private System.Windows.Forms.Button dwn_btn;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Button lft_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox Output;

        public System.EventHandler abort_btn_Click { get; set; }
    }
}

