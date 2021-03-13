namespace PKL_penjadwalan.GUI
{
    partial class Frm_MatPel
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
            this.TB_NamMatpel = new System.Windows.Forms.TextBox();
            this.TB_KodeMatpel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Matpel = new System.Windows.Forms.ComboBox();
            this.Btn_OKMtpl = new System.Windows.Forms.Button();
            this.Btn_CnclMtpl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RB_Siang = new System.Windows.Forms.RadioButton();
            this.RB_Pagi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(480, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 430);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 410);
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
            this.panel4.Size = new System.Drawing.Size(20, 430);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama Matpel";
            // 
            // TB_NamMatpel
            // 
            this.TB_NamMatpel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NamMatpel.Location = new System.Drawing.Point(197, 117);
            this.TB_NamMatpel.Name = "TB_NamMatpel";
            this.TB_NamMatpel.Size = new System.Drawing.Size(260, 29);
            this.TB_NamMatpel.TabIndex = 5;
            // 
            // TB_KodeMatpel
            // 
            this.TB_KodeMatpel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_KodeMatpel.Location = new System.Drawing.Point(197, 167);
            this.TB_KodeMatpel.Name = "TB_KodeMatpel";
            this.TB_KodeMatpel.Size = new System.Drawing.Size(158, 29);
            this.TB_KodeMatpel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jenis";
            // 
            // CB_Matpel
            // 
            this.CB_Matpel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Matpel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Matpel.Items.AddRange(new object[] {
            "Wajib",
            "Minat",
            "Lintas Minat"});
            this.CB_Matpel.Location = new System.Drawing.Point(197, 217);
            this.CB_Matpel.Name = "CB_Matpel";
            this.CB_Matpel.Size = new System.Drawing.Size(158, 30);
            this.CB_Matpel.TabIndex = 9;
            this.CB_Matpel.SelectedIndex = 0;
            // 
            // Btn_OKMtpl
            // 
            this.Btn_OKMtpl.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_OKMtpl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OKMtpl.Location = new System.Drawing.Point(375, 350);
            this.Btn_OKMtpl.Name = "Btn_OKMtpl";
            this.Btn_OKMtpl.Size = new System.Drawing.Size(80, 40);
            this.Btn_OKMtpl.TabIndex = 10;
            this.Btn_OKMtpl.Text = "&OK";
            this.Btn_OKMtpl.UseVisualStyleBackColor = true;
            this.Btn_OKMtpl.Click += new System.EventHandler(this.Btn_OKMtpl_Click);
            // 
            // Btn_CnclMtpl
            // 
            this.Btn_CnclMtpl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_CnclMtpl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CnclMtpl.Location = new System.Drawing.Point(275, 350);
            this.Btn_CnclMtpl.Name = "Btn_CnclMtpl";
            this.Btn_CnclMtpl.Size = new System.Drawing.Size(80, 40);
            this.Btn_CnclMtpl.TabIndex = 11;
            this.Btn_CnclMtpl.Text = "Cancel";
            this.Btn_CnclMtpl.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mata Pelajaran";
            // 
            // RB_Siang
            // 
            this.RB_Siang.AutoSize = true;
            this.RB_Siang.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Siang.Location = new System.Drawing.Point(193, 300);
            this.RB_Siang.Name = "RB_Siang";
            this.RB_Siang.Size = new System.Drawing.Size(67, 26);
            this.RB_Siang.TabIndex = 17;
            this.RB_Siang.TabStop = true;
            this.RB_Siang.Text = "Siang";
            this.RB_Siang.UseVisualStyleBackColor = true;
            // 
            // RB_Pagi
            // 
            this.RB_Pagi.AutoSize = true;
            this.RB_Pagi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Pagi.Location = new System.Drawing.Point(193, 268);
            this.RB_Pagi.Name = "RB_Pagi";
            this.RB_Pagi.Size = new System.Drawing.Size(58, 26);
            this.RB_Pagi.TabIndex = 16;
            this.RB_Pagi.TabStop = true;
            this.RB_Pagi.Text = "Pagi";
            this.RB_Pagi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Waktu";
            // 
            // Frm_IsiMatPel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Btn_CnclMtpl;
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.Controls.Add(this.RB_Siang);
            this.Controls.Add(this.RB_Pagi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_CnclMtpl);
            this.Controls.Add(this.Btn_OKMtpl);
            this.Controls.Add(this.CB_Matpel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_KodeMatpel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NamMatpel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_IsiMatPel";
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
        private System.Windows.Forms.TextBox TB_NamMatpel;
        private System.Windows.Forms.TextBox TB_KodeMatpel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Matpel;
        private System.Windows.Forms.Button Btn_OKMtpl;
        private System.Windows.Forms.Button Btn_CnclMtpl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RB_Siang;
        private System.Windows.Forms.RadioButton RB_Pagi;
        private System.Windows.Forms.Label label5;
    }
}