namespace PKL_penjadwalan.GUI
{
    partial class Frm_Legend
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridViewShow_Guru = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridViewShow_Matpel = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewShow_MGMP = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewShow_Guru)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewShow_Matpel)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewShow_MGMP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keterangan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridViewShow_Guru);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 604);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guru";
            // 
            // GridViewShow_Guru
            // 
            this.GridViewShow_Guru.AllowUserToAddRows = false;
            this.GridViewShow_Guru.AllowUserToDeleteRows = false;
            this.GridViewShow_Guru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewShow_Guru.BackgroundColor = System.Drawing.Color.White;
            this.GridViewShow_Guru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewShow_Guru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GridViewShow_Guru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewShow_Guru.Location = new System.Drawing.Point(3, 24);
            this.GridViewShow_Guru.Name = "GridViewShow_Guru";
            this.GridViewShow_Guru.ReadOnly = true;
            this.GridViewShow_Guru.Size = new System.Drawing.Size(429, 577);
            this.GridViewShow_Guru.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 35F;
            this.Column1.HeaderText = "Kode Guru";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Guru";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewShow_Matpel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(450, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 397);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mata Pelajaran";
            // 
            // GridViewShow_Matpel
            // 
            this.GridViewShow_Matpel.AllowUserToAddRows = false;
            this.GridViewShow_Matpel.AllowUserToDeleteRows = false;
            this.GridViewShow_Matpel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewShow_Matpel.BackgroundColor = System.Drawing.Color.White;
            this.GridViewShow_Matpel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewShow_Matpel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.GridViewShow_Matpel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewShow_Matpel.Location = new System.Drawing.Point(3, 24);
            this.GridViewShow_Matpel.Name = "GridViewShow_Matpel";
            this.GridViewShow_Matpel.ReadOnly = true;
            this.GridViewShow_Matpel.Size = new System.Drawing.Size(428, 370);
            this.GridViewShow_Matpel.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 35F;
            this.Column3.HeaderText = "Kode MatPel";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nama Matpel";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridViewShow_MGMP);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(450, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 192);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MGMP";
            // 
            // GridViewShow_MGMP
            // 
            this.GridViewShow_MGMP.AllowUserToAddRows = false;
            this.GridViewShow_MGMP.AllowUserToDeleteRows = false;
            this.GridViewShow_MGMP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewShow_MGMP.BackgroundColor = System.Drawing.Color.White;
            this.GridViewShow_MGMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewShow_MGMP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.GridViewShow_MGMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewShow_MGMP.Location = new System.Drawing.Point(3, 24);
            this.GridViewShow_MGMP.Name = "GridViewShow_MGMP";
            this.GridViewShow_MGMP.ReadOnly = true;
            this.GridViewShow_MGMP.Size = new System.Drawing.Size(428, 165);
            this.GridViewShow_MGMP.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 35F;
            this.Column5.HeaderText = "Hari";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "MGMP";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(435, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 604);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(450, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 15);
            this.panel2.TabIndex = 5;
            // 
            // Frm_Legend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Legend";
            this.Text = "FormLegend";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Legend_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Legend_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewShow_Guru)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewShow_Matpel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewShow_MGMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridViewShow_Guru;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridViewShow_Matpel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridViewShow_MGMP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}