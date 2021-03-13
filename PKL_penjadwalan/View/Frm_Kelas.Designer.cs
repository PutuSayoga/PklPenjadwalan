namespace PKL_penjadwalan.GUI
{
    partial class Frm_Kelas
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
            this.TB_NamaKls = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Kls = new System.Windows.Forms.ComboBox();
            this.Btn_OKKls = new System.Windows.Forms.Button();
            this.Btn_CnclKls = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RB_10 = new System.Windows.Forms.RadioButton();
            this.RB_11 = new System.Windows.Forms.RadioButton();
            this.RB_12 = new System.Windows.Forms.RadioButton();
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
            this.label1.Location = new System.Drawing.Point(82, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama Kelas";
            // 
            // TB_NamaKls
            // 
            this.TB_NamaKls.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NamaKls.Location = new System.Drawing.Point(197, 111);
            this.TB_NamaKls.Name = "TB_NamaKls";
            this.TB_NamaKls.Size = new System.Drawing.Size(260, 29);
            this.TB_NamaKls.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jenis";
            // 
            // CB_Kls
            // 
            this.CB_Kls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Kls.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Kls.Items.AddRange(new object[] {
            "MIA",
            "IIS"});
            this.CB_Kls.Location = new System.Drawing.Point(197, 210);
            this.CB_Kls.Name = "CB_Kls";
            this.CB_Kls.Size = new System.Drawing.Size(95, 30);
            this.CB_Kls.TabIndex = 9;
            // 
            // Btn_OKKls
            // 
            this.Btn_OKKls.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_OKKls.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OKKls.Location = new System.Drawing.Point(375, 270);
            this.Btn_OKKls.Name = "Btn_OKKls";
            this.Btn_OKKls.Size = new System.Drawing.Size(80, 40);
            this.Btn_OKKls.TabIndex = 10;
            this.Btn_OKKls.Text = "&OK";
            this.Btn_OKKls.UseVisualStyleBackColor = true;
            this.Btn_OKKls.Click += new System.EventHandler(this.Btn_OKKls_Click);
            // 
            // Btn_CnclKls
            // 
            this.Btn_CnclKls.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_CnclKls.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CnclKls.Location = new System.Drawing.Point(275, 270);
            this.Btn_CnclKls.Name = "Btn_CnclKls";
            this.Btn_CnclKls.Size = new System.Drawing.Size(80, 40);
            this.Btn_CnclKls.TabIndex = 11;
            this.Btn_CnclKls.Text = "Cancel";
            this.Btn_CnclKls.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kelas";
            // 
            // RB_10
            // 
            this.RB_10.AutoSize = true;
            this.RB_10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_10.Location = new System.Drawing.Point(197, 161);
            this.RB_10.Name = "RB_10";
            this.RB_10.Size = new System.Drawing.Size(44, 26);
            this.RB_10.TabIndex = 13;
            this.RB_10.TabStop = true;
            this.RB_10.Text = "10";
            this.RB_10.UseVisualStyleBackColor = true;
            // 
            // RB_11
            // 
            this.RB_11.AutoSize = true;
            this.RB_11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_11.Location = new System.Drawing.Point(307, 161);
            this.RB_11.Name = "RB_11";
            this.RB_11.Size = new System.Drawing.Size(44, 26);
            this.RB_11.TabIndex = 14;
            this.RB_11.TabStop = true;
            this.RB_11.Text = "11";
            this.RB_11.UseVisualStyleBackColor = true;
            // 
            // RB_12
            // 
            this.RB_12.AutoSize = true;
            this.RB_12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_12.Location = new System.Drawing.Point(413, 161);
            this.RB_12.Name = "RB_12";
            this.RB_12.Size = new System.Drawing.Size(44, 26);
            this.RB_12.TabIndex = 15;
            this.RB_12.TabStop = true;
            this.RB_12.Text = "12";
            this.RB_12.UseVisualStyleBackColor = true;
            // 
            // Frm_IsiKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.Btn_CnclKls;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.RB_12);
            this.Controls.Add(this.RB_11);
            this.Controls.Add(this.RB_10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_CnclKls);
            this.Controls.Add(this.Btn_OKKls);
            this.Controls.Add(this.CB_Kls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NamaKls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_IsiKelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox TB_NamaKls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Kls;
        private System.Windows.Forms.Button Btn_OKKls;
        private System.Windows.Forms.Button Btn_CnclKls;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RB_10;
        private System.Windows.Forms.RadioButton RB_11;
        private System.Windows.Forms.RadioButton RB_12;
    }
}