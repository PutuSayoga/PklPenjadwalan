namespace PKL_penjadwalan.GUI.Control
{
    partial class UC_IsiSK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.B_Load = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.GridView_Tugas = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.B_Execute = new System.Windows.Forms.Button();
            this.B_EditTugas = new System.Windows.Forms.Button();
            this.B_HapusTugas = new System.Windows.Forms.Button();
            this.B_TambahTugas = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GridView_Kelas = new System.Windows.Forms.DataGridView();
            this.Clm_NmKls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Angkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_JnsKls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.B_EditKelas = new System.Windows.Forms.Button();
            this.B_HapusKelas = new System.Windows.Forms.Button();
            this.B_TambahKelas = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridView_Guru = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.B_EditGuru = new System.Windows.Forms.Button();
            this.B_HapusGuru = new System.Windows.Forms.Button();
            this.B_TambahGuru = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GridView_Matpel = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_EditMatpel = new System.Windows.Forms.Button();
            this.B_HapusMatpel = new System.Windows.Forms.Button();
            this.B_TambahMatpel = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Clm_NmMatpel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_KodeMatpel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_JnsMatpel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_NmGuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_KodeGuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_MGMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_NamaGuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_NamaMatpel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_KodeTugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_JatahNgajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_JatahKls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Tugas)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Kelas)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Guru)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Matpel)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Controls.Add(this.B_Load);
            this.panel3.Controls.Add(this.B_Save);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 95);
            this.panel3.TabIndex = 8;
            // 
            // B_Load
            // 
            this.B_Load.Location = new System.Drawing.Point(990, 29);
            this.B_Load.Name = "B_Load";
            this.B_Load.Size = new System.Drawing.Size(80, 40);
            this.B_Load.TabIndex = 3;
            this.B_Load.Text = "Load";
            this.B_Load.UseVisualStyleBackColor = true;
            this.B_Load.Click += new System.EventHandler(this.B_Load_Click);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(890, 29);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(80, 40);
            this.B_Save.TabIndex = 2;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pengisian SK";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.GridView_Tugas);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1107, 567);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tugas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // GridView_Tugas
            // 
            this.GridView_Tugas.AllowUserToAddRows = false;
            this.GridView_Tugas.AllowUserToDeleteRows = false;
            this.GridView_Tugas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Tugas.BackgroundColor = System.Drawing.Color.White;
            this.GridView_Tugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Tugas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_NamaGuru,
            this.Clm_NamaMatpel,
            this.Clm_KodeTugas,
            this.Clm_JatahNgajar,
            this.Clm_JatahKls});
            this.GridView_Tugas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView_Tugas.Location = new System.Drawing.Point(3, 3);
            this.GridView_Tugas.Name = "GridView_Tugas";
            this.GridView_Tugas.ReadOnly = true;
            this.GridView_Tugas.Size = new System.Drawing.Size(901, 561);
            this.GridView_Tugas.TabIndex = 2;
            this.GridView_Tugas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Tugas_CellEnter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.B_Execute);
            this.panel4.Controls.Add(this.B_EditTugas);
            this.panel4.Controls.Add(this.B_HapusTugas);
            this.panel4.Controls.Add(this.B_TambahTugas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(904, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 561);
            this.panel4.TabIndex = 1;
            // 
            // B_Execute
            // 
            this.B_Execute.Location = new System.Drawing.Point(50, 460);
            this.B_Execute.Name = "B_Execute";
            this.B_Execute.Size = new System.Drawing.Size(100, 50);
            this.B_Execute.TabIndex = 6;
            this.B_Execute.Text = "Execute";
            this.B_Execute.UseVisualStyleBackColor = true;
            this.B_Execute.Click += new System.EventHandler(this.B_Execute_Click);
            // 
            // B_EditTugas
            // 
            this.B_EditTugas.Location = new System.Drawing.Point(60, 180);
            this.B_EditTugas.Name = "B_EditTugas";
            this.B_EditTugas.Size = new System.Drawing.Size(80, 40);
            this.B_EditTugas.TabIndex = 5;
            this.B_EditTugas.Text = "Edit";
            this.B_EditTugas.UseVisualStyleBackColor = true;
            this.B_EditTugas.Click += new System.EventHandler(this.B_EditTugas_Click);
            // 
            // B_HapusTugas
            // 
            this.B_HapusTugas.Location = new System.Drawing.Point(60, 240);
            this.B_HapusTugas.Name = "B_HapusTugas";
            this.B_HapusTugas.Size = new System.Drawing.Size(80, 40);
            this.B_HapusTugas.TabIndex = 4;
            this.B_HapusTugas.Text = "Hapus";
            this.B_HapusTugas.UseVisualStyleBackColor = true;
            this.B_HapusTugas.Click += new System.EventHandler(this.B_HapusTugas_Click);
            // 
            // B_TambahTugas
            // 
            this.B_TambahTugas.Location = new System.Drawing.Point(60, 120);
            this.B_TambahTugas.Name = "B_TambahTugas";
            this.B_TambahTugas.Size = new System.Drawing.Size(80, 40);
            this.B_TambahTugas.TabIndex = 3;
            this.B_TambahTugas.Text = "Tambah";
            this.B_TambahTugas.UseVisualStyleBackColor = true;
            this.B_TambahTugas.Click += new System.EventHandler(this.B_TambahTugas_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GridView_Kelas);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1107, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kelas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GridView_Kelas
            // 
            this.GridView_Kelas.AllowUserToAddRows = false;
            this.GridView_Kelas.AllowUserToDeleteRows = false;
            this.GridView_Kelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Kelas.BackgroundColor = System.Drawing.Color.White;
            this.GridView_Kelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Kelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_NmKls,
            this.Clm_Angkatan,
            this.Clm_JnsKls});
            this.GridView_Kelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView_Kelas.Location = new System.Drawing.Point(3, 3);
            this.GridView_Kelas.Name = "GridView_Kelas";
            this.GridView_Kelas.ReadOnly = true;
            this.GridView_Kelas.Size = new System.Drawing.Size(901, 561);
            this.GridView_Kelas.TabIndex = 1;
            this.GridView_Kelas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Kelas_CellEnter);
            // 
            // Clm_NmKls
            // 
            this.Clm_NmKls.HeaderText = "Nama Kelas";
            this.Clm_NmKls.Name = "Clm_NmKls";
            this.Clm_NmKls.ReadOnly = true;
            // 
            // Clm_Angkatan
            // 
            this.Clm_Angkatan.HeaderText = "Angkatan";
            this.Clm_Angkatan.Name = "Clm_Angkatan";
            this.Clm_Angkatan.ReadOnly = true;
            // 
            // Clm_JnsKls
            // 
            this.Clm_JnsKls.HeaderText = "Jenis";
            this.Clm_JnsKls.Name = "Clm_JnsKls";
            this.Clm_JnsKls.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.B_EditKelas);
            this.panel5.Controls.Add(this.B_HapusKelas);
            this.panel5.Controls.Add(this.B_TambahKelas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(904, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 561);
            this.panel5.TabIndex = 0;
            // 
            // B_EditKelas
            // 
            this.B_EditKelas.Location = new System.Drawing.Point(60, 180);
            this.B_EditKelas.Name = "B_EditKelas";
            this.B_EditKelas.Size = new System.Drawing.Size(80, 40);
            this.B_EditKelas.TabIndex = 5;
            this.B_EditKelas.Text = "Edit";
            this.B_EditKelas.UseVisualStyleBackColor = true;
            this.B_EditKelas.Click += new System.EventHandler(this.B_EditKelas_Click);
            // 
            // B_HapusKelas
            // 
            this.B_HapusKelas.Location = new System.Drawing.Point(60, 240);
            this.B_HapusKelas.Name = "B_HapusKelas";
            this.B_HapusKelas.Size = new System.Drawing.Size(80, 40);
            this.B_HapusKelas.TabIndex = 4;
            this.B_HapusKelas.Text = "Hapus";
            this.B_HapusKelas.UseVisualStyleBackColor = true;
            this.B_HapusKelas.Click += new System.EventHandler(this.B_HapusKelas_Click);
            // 
            // B_TambahKelas
            // 
            this.B_TambahKelas.Location = new System.Drawing.Point(60, 120);
            this.B_TambahKelas.Name = "B_TambahKelas";
            this.B_TambahKelas.Size = new System.Drawing.Size(80, 40);
            this.B_TambahKelas.TabIndex = 3;
            this.B_TambahKelas.Text = "Tambah";
            this.B_TambahKelas.UseVisualStyleBackColor = true;
            this.B_TambahKelas.Click += new System.EventHandler(this.B_TambahKelas_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridView_Guru);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Guru";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridView_Guru
            // 
            this.GridView_Guru.AllowUserToAddRows = false;
            this.GridView_Guru.AllowUserToDeleteRows = false;
            this.GridView_Guru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Guru.BackgroundColor = System.Drawing.Color.White;
            this.GridView_Guru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Guru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_NmGuru,
            this.Clm_KodeGuru,
            this.Clm_MGMP});
            this.GridView_Guru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView_Guru.Location = new System.Drawing.Point(3, 3);
            this.GridView_Guru.Name = "GridView_Guru";
            this.GridView_Guru.ReadOnly = true;
            this.GridView_Guru.Size = new System.Drawing.Size(901, 561);
            this.GridView_Guru.TabIndex = 1;
            this.GridView_Guru.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Guru_CellEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.B_EditGuru);
            this.panel2.Controls.Add(this.B_HapusGuru);
            this.panel2.Controls.Add(this.B_TambahGuru);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(904, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 561);
            this.panel2.TabIndex = 0;
            // 
            // B_EditGuru
            // 
            this.B_EditGuru.Enabled = false;
            this.B_EditGuru.Location = new System.Drawing.Point(60, 180);
            this.B_EditGuru.Name = "B_EditGuru";
            this.B_EditGuru.Size = new System.Drawing.Size(80, 40);
            this.B_EditGuru.TabIndex = 5;
            this.B_EditGuru.Text = "Edit";
            this.B_EditGuru.UseVisualStyleBackColor = true;
            this.B_EditGuru.Click += new System.EventHandler(this.B_EditGuru_Click);
            // 
            // B_HapusGuru
            // 
            this.B_HapusGuru.Enabled = false;
            this.B_HapusGuru.Location = new System.Drawing.Point(60, 240);
            this.B_HapusGuru.Name = "B_HapusGuru";
            this.B_HapusGuru.Size = new System.Drawing.Size(80, 40);
            this.B_HapusGuru.TabIndex = 4;
            this.B_HapusGuru.Text = "Hapus";
            this.B_HapusGuru.UseVisualStyleBackColor = true;
            this.B_HapusGuru.Click += new System.EventHandler(this.B_HapusGuru_Click);
            // 
            // B_TambahGuru
            // 
            this.B_TambahGuru.Location = new System.Drawing.Point(60, 120);
            this.B_TambahGuru.Name = "B_TambahGuru";
            this.B_TambahGuru.Size = new System.Drawing.Size(80, 40);
            this.B_TambahGuru.TabIndex = 3;
            this.B_TambahGuru.Text = "Tambah";
            this.B_TambahGuru.UseVisualStyleBackColor = true;
            this.B_TambahGuru.Click += new System.EventHandler(this.B_TambahGuru_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GridView_Matpel);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mata Pelajaran";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GridView_Matpel
            // 
            this.GridView_Matpel.AllowUserToAddRows = false;
            this.GridView_Matpel.AllowUserToDeleteRows = false;
            this.GridView_Matpel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Matpel.BackgroundColor = System.Drawing.Color.White;
            this.GridView_Matpel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Matpel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_NmMatpel,
            this.Clm_KodeMatpel,
            this.Clm_JnsMatpel,
            this.Clm_Waktu});
            this.GridView_Matpel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView_Matpel.Location = new System.Drawing.Point(3, 3);
            this.GridView_Matpel.Name = "GridView_Matpel";
            this.GridView_Matpel.ReadOnly = true;
            this.GridView_Matpel.Size = new System.Drawing.Size(901, 561);
            this.GridView_Matpel.TabIndex = 1;
            this.GridView_Matpel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Matpel_CellEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_EditMatpel);
            this.panel1.Controls.Add(this.B_HapusMatpel);
            this.panel1.Controls.Add(this.B_TambahMatpel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(904, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 0;
            // 
            // B_EditMatpel
            // 
            this.B_EditMatpel.Enabled = false;
            this.B_EditMatpel.Location = new System.Drawing.Point(60, 180);
            this.B_EditMatpel.Name = "B_EditMatpel";
            this.B_EditMatpel.Size = new System.Drawing.Size(80, 40);
            this.B_EditMatpel.TabIndex = 2;
            this.B_EditMatpel.Text = "Edit";
            this.B_EditMatpel.UseVisualStyleBackColor = true;
            this.B_EditMatpel.Click += new System.EventHandler(this.B_EditMatpel_Click);
            // 
            // B_HapusMatpel
            // 
            this.B_HapusMatpel.Enabled = false;
            this.B_HapusMatpel.Location = new System.Drawing.Point(60, 240);
            this.B_HapusMatpel.Name = "B_HapusMatpel";
            this.B_HapusMatpel.Size = new System.Drawing.Size(80, 40);
            this.B_HapusMatpel.TabIndex = 1;
            this.B_HapusMatpel.Text = "Hapus";
            this.B_HapusMatpel.UseVisualStyleBackColor = true;
            this.B_HapusMatpel.Click += new System.EventHandler(this.B_HapusMatpel_Click);
            // 
            // B_TambahMatpel
            // 
            this.B_TambahMatpel.Location = new System.Drawing.Point(60, 120);
            this.B_TambahMatpel.Name = "B_TambahMatpel";
            this.B_TambahMatpel.Size = new System.Drawing.Size(80, 40);
            this.B_TambahMatpel.TabIndex = 0;
            this.B_TambahMatpel.Text = "Tambah";
            this.B_TambahMatpel.UseVisualStyleBackColor = true;
            this.B_TambahMatpel.Click += new System.EventHandler(this.B_TambahMatpel_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 95);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1115, 600);
            this.tabControl.TabIndex = 9;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Clm_NmMatpel
            // 
            this.Clm_NmMatpel.HeaderText = "Nama Matpel";
            this.Clm_NmMatpel.Name = "Clm_NmMatpel";
            this.Clm_NmMatpel.ReadOnly = true;
            // 
            // Clm_KodeMatpel
            // 
            this.Clm_KodeMatpel.FillWeight = 50F;
            this.Clm_KodeMatpel.HeaderText = "Kode";
            this.Clm_KodeMatpel.Name = "Clm_KodeMatpel";
            this.Clm_KodeMatpel.ReadOnly = true;
            // 
            // Clm_JnsMatpel
            // 
            this.Clm_JnsMatpel.FillWeight = 80F;
            this.Clm_JnsMatpel.HeaderText = "Jenis";
            this.Clm_JnsMatpel.Name = "Clm_JnsMatpel";
            this.Clm_JnsMatpel.ReadOnly = true;
            // 
            // Clm_Waktu
            // 
            this.Clm_Waktu.FillWeight = 50F;
            this.Clm_Waktu.HeaderText = "Waktu";
            this.Clm_Waktu.Name = "Clm_Waktu";
            this.Clm_Waktu.ReadOnly = true;
            // 
            // Clm_NmGuru
            // 
            this.Clm_NmGuru.HeaderText = "Nama Guru";
            this.Clm_NmGuru.Name = "Clm_NmGuru";
            this.Clm_NmGuru.ReadOnly = true;
            // 
            // Clm_KodeGuru
            // 
            this.Clm_KodeGuru.FillWeight = 40F;
            this.Clm_KodeGuru.HeaderText = "Kode";
            this.Clm_KodeGuru.Name = "Clm_KodeGuru";
            this.Clm_KodeGuru.ReadOnly = true;
            // 
            // Clm_MGMP
            // 
            this.Clm_MGMP.FillWeight = 50F;
            this.Clm_MGMP.HeaderText = "MGMP";
            this.Clm_MGMP.Name = "Clm_MGMP";
            this.Clm_MGMP.ReadOnly = true;
            // 
            // Clm_NamaGuru
            // 
            this.Clm_NamaGuru.HeaderText = "Nama Guru";
            this.Clm_NamaGuru.Name = "Clm_NamaGuru";
            this.Clm_NamaGuru.ReadOnly = true;
            // 
            // Clm_NamaMatpel
            // 
            this.Clm_NamaMatpel.HeaderText = "Nama MatPel";
            this.Clm_NamaMatpel.Name = "Clm_NamaMatpel";
            this.Clm_NamaMatpel.ReadOnly = true;
            // 
            // Clm_KodeTugas
            // 
            this.Clm_KodeTugas.FillWeight = 60F;
            this.Clm_KodeTugas.HeaderText = "Kode Tugas";
            this.Clm_KodeTugas.Name = "Clm_KodeTugas";
            this.Clm_KodeTugas.ReadOnly = true;
            // 
            // Clm_JatahNgajar
            // 
            this.Clm_JatahNgajar.FillWeight = 50F;
            this.Clm_JatahNgajar.HeaderText = "Jatah Jam";
            this.Clm_JatahNgajar.Name = "Clm_JatahNgajar";
            this.Clm_JatahNgajar.ReadOnly = true;
            // 
            // Clm_JatahKls
            // 
            this.Clm_JatahKls.HeaderText = "Jatah Kelas";
            this.Clm_JatahKls.Name = "Clm_JatahKls";
            this.Clm_JatahKls.ReadOnly = true;
            // 
            // UC_IsiSK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_IsiSK";
            this.Size = new System.Drawing.Size(1115, 695);
            this.Load += new System.EventHandler(this.UC_IsiSK_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Tugas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Kelas)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Guru)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Matpel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Load;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView GridView_Tugas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button B_Execute;
        private System.Windows.Forms.Button B_EditTugas;
        private System.Windows.Forms.Button B_HapusTugas;
        private System.Windows.Forms.Button B_TambahTugas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView GridView_Kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_NmKls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Angkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_JnsKls;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button B_EditKelas;
        private System.Windows.Forms.Button B_HapusKelas;
        private System.Windows.Forms.Button B_TambahKelas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView GridView_Guru;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button B_EditGuru;
        private System.Windows.Forms.Button B_HapusGuru;
        private System.Windows.Forms.Button B_TambahGuru;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView GridView_Matpel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_EditMatpel;
        private System.Windows.Forms.Button B_HapusMatpel;
        private System.Windows.Forms.Button B_TambahMatpel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_NamaGuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_NamaMatpel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_KodeTugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_JatahNgajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_JatahKls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_NmGuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_KodeGuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_MGMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_NmMatpel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_KodeMatpel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_JnsMatpel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Waktu;
    }
}
