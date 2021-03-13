namespace PKL_penjadwalan.GUI
{
    partial class Frm_Guru
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_namaGuru = new System.Windows.Forms.TextBox();
            this.TB_KodeGuru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_OKGuru = new System.Windows.Forms.Button();
            this.Btn_CnclGuru = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.L_MGMP = new System.Windows.Forms.Label();
            this.CB_MGMP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(480, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 350);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 20);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 20);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 350);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama Guru";
            // 
            // TB_namaGuru
            // 
            this.TB_namaGuru.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_namaGuru.Location = new System.Drawing.Point(197, 114);
            this.TB_namaGuru.Name = "TB_namaGuru";
            this.TB_namaGuru.Size = new System.Drawing.Size(260, 29);
            this.TB_namaGuru.TabIndex = 5;
            // 
            // TB_KodeGuru
            // 
            this.TB_KodeGuru.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_KodeGuru.Location = new System.Drawing.Point(197, 163);
            this.TB_KodeGuru.Name = "TB_KodeGuru";
            this.TB_KodeGuru.Size = new System.Drawing.Size(110, 29);
            this.TB_KodeGuru.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kode";
            // 
            // Btn_OKGuru
            // 
            this.Btn_OKGuru.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_OKGuru.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OKGuru.Location = new System.Drawing.Point(375, 270);
            this.Btn_OKGuru.Name = "Btn_OKGuru";
            this.Btn_OKGuru.Size = new System.Drawing.Size(80, 40);
            this.Btn_OKGuru.TabIndex = 10;
            this.Btn_OKGuru.Text = "&OK";
            this.Btn_OKGuru.UseVisualStyleBackColor = true;
            this.Btn_OKGuru.Click += new System.EventHandler(this.Btn_OKGuru_Click);
            // 
            // Btn_CnclGuru
            // 
            this.Btn_CnclGuru.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_CnclGuru.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CnclGuru.Location = new System.Drawing.Point(275, 270);
            this.Btn_CnclGuru.Name = "Btn_CnclGuru";
            this.Btn_CnclGuru.Size = new System.Drawing.Size(80, 40);
            this.Btn_CnclGuru.TabIndex = 11;
            this.Btn_CnclGuru.Text = "Cancel";
            this.Btn_CnclGuru.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Guru";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // L_MGMP
            // 
            this.L_MGMP.AutoSize = true;
            this.L_MGMP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MGMP.Location = new System.Drawing.Point(102, 215);
            this.L_MGMP.Name = "L_MGMP";
            this.L_MGMP.Size = new System.Drawing.Size(62, 22);
            this.L_MGMP.TabIndex = 13;
            this.L_MGMP.Text = "MGMP";
            // 
            // CB_MGMP
            // 
            this.CB_MGMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MGMP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_MGMP.Items.AddRange(new object[] {
            "Tidak Ada",
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu"});
            this.CB_MGMP.Location = new System.Drawing.Point(197, 212);
            this.CB_MGMP.Name = "CB_MGMP";
            this.CB_MGMP.Size = new System.Drawing.Size(140, 30);
            this.CB_MGMP.TabIndex = 14;
            this.CB_MGMP.SelectedIndex = 0;
            // 
            // Frm_IsiGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Btn_CnclGuru;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.CB_MGMP);
            this.Controls.Add(this.L_MGMP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_CnclGuru);
            this.Controls.Add(this.Btn_OKGuru);
            this.Controls.Add(this.TB_KodeGuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_namaGuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_IsiGuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "matPel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_namaGuru;
        private System.Windows.Forms.TextBox TB_KodeGuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_OKGuru;
        private System.Windows.Forms.Button Btn_CnclGuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label L_MGMP;
        private System.Windows.Forms.ComboBox CB_MGMP;
    }
}