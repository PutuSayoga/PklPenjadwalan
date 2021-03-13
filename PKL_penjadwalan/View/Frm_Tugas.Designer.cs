namespace PKL_penjadwalan.GUI
{
    partial class Frm_Tugas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_OKTgs = new System.Windows.Forms.Button();
            this.Btn_CnclTgs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_NamaGuru = new System.Windows.Forms.ComboBox();
            this.CL_Kelas = new System.Windows.Forms.CheckedListBox();
            this.CB_NamaMatpel = new System.Windows.Forms.ComboBox();
            this.L_ErrorKelas = new System.Windows.Forms.Label();
            this.L_ErrorGuru = new System.Windows.Forms.Label();
            this.L_ErrorMatpel = new System.Windows.Forms.Label();
            this.CB_jam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(490, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 550);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 550);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 530);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 20);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(470, 20);
            this.panel4.TabIndex = 3;
            // 
            // Btn_OKTgs
            // 
            this.Btn_OKTgs.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_OKTgs.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.Btn_OKTgs.Location = new System.Drawing.Point(375, 475);
            this.Btn_OKTgs.Name = "Btn_OKTgs";
            this.Btn_OKTgs.Size = new System.Drawing.Size(80, 40);
            this.Btn_OKTgs.TabIndex = 4;
            this.Btn_OKTgs.Text = "&OK";
            this.Btn_OKTgs.UseVisualStyleBackColor = true;
            this.Btn_OKTgs.Click += new System.EventHandler(this.Btn_OKTgs_Click);
            // 
            // Btn_CnclTgs
            // 
            this.Btn_CnclTgs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_CnclTgs.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Btn_CnclTgs.Location = new System.Drawing.Point(275, 475);
            this.Btn_CnclTgs.Name = "Btn_CnclTgs";
            this.Btn_CnclTgs.Size = new System.Drawing.Size(80, 40);
            this.Btn_CnclTgs.TabIndex = 5;
            this.Btn_CnclTgs.Text = "Cancel";
            this.Btn_CnclTgs.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tugas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.label1.Location = new System.Drawing.Point(82, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nama Guru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.label2.Location = new System.Drawing.Point(69, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama Matpel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.label3.Location = new System.Drawing.Point(68, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Jam Mengajar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.label5.Location = new System.Drawing.Point(131, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kelas";
            // 
            // CB_NamaGuru
            // 
            this.CB_NamaGuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NamaGuru.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_NamaGuru.IntegralHeight = false;
            this.CB_NamaGuru.Location = new System.Drawing.Point(197, 111);
            this.CB_NamaGuru.Name = "CB_NamaGuru";
            this.CB_NamaGuru.Size = new System.Drawing.Size(260, 30);
            this.CB_NamaGuru.TabIndex = 18;
            // 
            // CL_Kelas
            // 
            this.CL_Kelas.BackColor = System.Drawing.SystemColors.Control;
            this.CL_Kelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CL_Kelas.CheckOnClick = true;
            this.CL_Kelas.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.CL_Kelas.FormattingEnabled = true;
            this.CL_Kelas.Location = new System.Drawing.Point(197, 270);
            this.CL_Kelas.Name = "CL_Kelas";
            this.CL_Kelas.ScrollAlwaysVisible = true;
            this.CL_Kelas.Size = new System.Drawing.Size(260, 152);
            this.CL_Kelas.TabIndex = 19;
            // 
            // CB_NamaMatpel
            // 
            this.CB_NamaMatpel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NamaMatpel.DropDownWidth = 260;
            this.CB_NamaMatpel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_NamaMatpel.IntegralHeight = false;
            this.CB_NamaMatpel.Location = new System.Drawing.Point(197, 164);
            this.CB_NamaMatpel.Name = "CB_NamaMatpel";
            this.CB_NamaMatpel.Size = new System.Drawing.Size(260, 30);
            this.CB_NamaMatpel.TabIndex = 20;
            // 
            // L_ErrorKelas
            // 
            this.L_ErrorKelas.AutoSize = true;
            this.L_ErrorKelas.ForeColor = System.Drawing.Color.Red;
            this.L_ErrorKelas.Location = new System.Drawing.Point(193, 425);
            this.L_ErrorKelas.Name = "L_ErrorKelas";
            this.L_ErrorKelas.Size = new System.Drawing.Size(208, 20);
            this.L_ErrorKelas.TabIndex = 22;
            this.L_ErrorKelas.Text = "*Data ruang kelas belum terisi";
            this.L_ErrorKelas.Visible = false;
            // 
            // L_ErrorGuru
            // 
            this.L_ErrorGuru.AutoSize = true;
            this.L_ErrorGuru.ForeColor = System.Drawing.Color.Red;
            this.L_ErrorGuru.Location = new System.Drawing.Point(193, 111);
            this.L_ErrorGuru.Name = "L_ErrorGuru";
            this.L_ErrorGuru.Size = new System.Drawing.Size(14, 20);
            this.L_ErrorGuru.TabIndex = 23;
            this.L_ErrorGuru.Text = "-";
            // 
            // L_ErrorMatpel
            // 
            this.L_ErrorMatpel.AutoSize = true;
            this.L_ErrorMatpel.ForeColor = System.Drawing.Color.Red;
            this.L_ErrorMatpel.Location = new System.Drawing.Point(193, 164);
            this.L_ErrorMatpel.Name = "L_ErrorMatpel";
            this.L_ErrorMatpel.Size = new System.Drawing.Size(14, 20);
            this.L_ErrorMatpel.TabIndex = 24;
            this.L_ErrorMatpel.Text = "-";
            // 
            // CB_jam
            // 
            this.CB_jam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_jam.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_jam.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CB_jam.Location = new System.Drawing.Point(197, 217);
            this.CB_jam.Name = "CB_jam";
            this.CB_jam.Size = new System.Drawing.Size(75, 30);
            this.CB_jam.TabIndex = 25;
            // 
            // Frm_IsiTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_CnclTgs;
            this.ClientSize = new System.Drawing.Size(510, 550);
            this.Controls.Add(this.CB_jam);
            this.Controls.Add(this.L_ErrorMatpel);
            this.Controls.Add(this.L_ErrorGuru);
            this.Controls.Add(this.L_ErrorKelas);
            this.Controls.Add(this.CB_NamaMatpel);
            this.Controls.Add(this.CL_Kelas);
            this.Controls.Add(this.CB_NamaGuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_CnclTgs);
            this.Controls.Add(this.Btn_OKTgs);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_IsiTugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_isiTugas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_OKTgs;
        private System.Windows.Forms.Button Btn_CnclTgs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_NamaGuru;
        private System.Windows.Forms.CheckedListBox CL_Kelas;
        private System.Windows.Forms.ComboBox CB_NamaMatpel;
        private System.Windows.Forms.Label L_ErrorKelas;
        private System.Windows.Forms.Label L_ErrorGuru;
        private System.Windows.Forms.Label L_ErrorMatpel;
        private System.Windows.Forms.ComboBox CB_jam;
    }
}