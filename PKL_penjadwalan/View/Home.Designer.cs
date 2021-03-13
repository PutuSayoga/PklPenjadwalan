namespace PKL_penjadwalan
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelJudul = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.panelDasboard = new System.Windows.Forms.Panel();
            this.B_UC_Hasil = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dashboard = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.B_UC_IsiSK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelJudul.SuspendLayout();
            this.panelDasboard.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelJudul
            // 
            this.panelJudul.BackColor = System.Drawing.SystemColors.Window;
            this.panelJudul.Controls.Add(this.close);
            this.panelJudul.Controls.Add(this.appName);
            this.panelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJudul.Location = new System.Drawing.Point(165, 0);
            this.panelJudul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelJudul.Name = "panelJudul";
            this.panelJudul.Size = new System.Drawing.Size(1115, 25);
            this.panelJudul.TabIndex = 0;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::PKL_penjadwalan.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(1075, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 25);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // appName
            // 
            this.appName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.Location = new System.Drawing.Point(370, 0);
            this.appName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(182, 22);
            this.appName.TabIndex = 0;
            this.appName.Text = "Penjadwalan SMA BSS";
            // 
            // panelDasboard
            // 
            this.panelDasboard.BackColor = System.Drawing.Color.BlueViolet;
            this.panelDasboard.Controls.Add(this.B_UC_Hasil);
            this.panelDasboard.Controls.Add(this.panel5);
            this.panelDasboard.Controls.Add(this.panelSlide);
            this.panelDasboard.Controls.Add(this.B_UC_IsiSK);
            this.panelDasboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDasboard.Location = new System.Drawing.Point(0, 0);
            this.panelDasboard.Name = "panelDasboard";
            this.panelDasboard.Size = new System.Drawing.Size(165, 720);
            this.panelDasboard.TabIndex = 3;
            // 
            // button2
            // 
            this.B_UC_Hasil.BackColor = System.Drawing.Color.Transparent;
            this.B_UC_Hasil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_UC_Hasil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_UC_Hasil.FlatAppearance.BorderSize = 0;
            this.B_UC_Hasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_UC_Hasil.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_UC_Hasil.ForeColor = System.Drawing.Color.White;
            this.B_UC_Hasil.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.B_UC_Hasil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_UC_Hasil.Location = new System.Drawing.Point(12, 170);
            this.B_UC_Hasil.Name = "button2";
            this.B_UC_Hasil.Size = new System.Drawing.Size(153, 40);
            this.B_UC_Hasil.TabIndex = 6;
            this.B_UC_Hasil.Text = "          Hasil";
            this.B_UC_Hasil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_UC_Hasil.UseVisualStyleBackColor = false;
            this.B_UC_Hasil.Click += new System.EventHandler(this.B_UC_Hasil_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dashboard);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 120);
            this.panel5.TabIndex = 5;
            // 
            // dashboard
            // 
            this.dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboard.AutoSize = true;
            this.dashboard.BackColor = System.Drawing.Color.Transparent;
            this.dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Image = global::PKL_penjadwalan.Properties.Resources.menu;
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(120, 25);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(44, 41);
            this.dashboard.TabIndex = 0;
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.GeserDasboard);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 120);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 50);
            this.panelSlide.TabIndex = 5;
            this.panelSlide.Visible = false;
            // 
            // button1
            // 
            this.B_UC_IsiSK.BackColor = System.Drawing.Color.Transparent;
            this.B_UC_IsiSK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_UC_IsiSK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_UC_IsiSK.FlatAppearance.BorderSize = 0;
            this.B_UC_IsiSK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_UC_IsiSK.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_UC_IsiSK.ForeColor = System.Drawing.Color.White;
            this.B_UC_IsiSK.Image = global::PKL_penjadwalan.Properties.Resources.pencil;
            this.B_UC_IsiSK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_UC_IsiSK.Location = new System.Drawing.Point(12, 125);
            this.B_UC_IsiSK.Name = "button1";
            this.B_UC_IsiSK.Size = new System.Drawing.Size(153, 40);
            this.B_UC_IsiSK.TabIndex = 1;
            this.B_UC_IsiSK.Text = "          Isi SK";
            this.B_UC_IsiSK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_UC_IsiSK.UseVisualStyleBackColor = false;
            this.B_UC_IsiSK.Click += new System.EventHandler(this.B_UC_IsiSK_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 95);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panel3);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(165, 25);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1115, 695);
            this.panelControl.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelJudul);
            this.Controls.Add(this.panelDasboard);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penjadwalan SMA BSS";
            this.panelJudul.ResumeLayout(false);
            this.panelJudul.PerformLayout();
            this.panelDasboard.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelJudul;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Panel panelDasboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button B_UC_IsiSK;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button B_UC_Hasil;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label label1;
    }
}

