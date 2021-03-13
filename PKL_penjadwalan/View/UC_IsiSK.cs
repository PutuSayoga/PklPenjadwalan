using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKL_penjadwalan.Model;
using AprioriGA;
using Newtonsoft.Json;

namespace PKL_penjadwalan.GUI.Control
{
    public partial class UC_IsiSK : UserControl
    {
        DataGridViewRow rowSelected;
        string detKode, detNama;
        int jatahJamTugas;


        public UC_IsiSK()
        {
            InitializeComponent();
        }

        //waktu milih menu isiSK
        private void UC_IsiSK_Load(object sender, EventArgs e)
        {
            tampilSemua();
        }

        //Mata Pelajaran
        private void B_TambahMatpel_Click(object sender, EventArgs e)
        {
            using (Frm_MatPel aFrmMatpel = new Frm_MatPel())
            {
                if (aFrmMatpel.ShowDialog() == DialogResult.OK)
                {
                    tampilSemua();
                }
            }
        }
        private void B_EditMatpel_Click(object sender, EventArgs e)
        {
            using (Frm_MatPel aFrmMatpel = new Frm_MatPel(detKode, detNama))
            {
                if (aFrmMatpel.ShowDialog() == DialogResult.OK)
                {
                    tampilSemua();
                }
            }
        }
        private void B_HapusMatpel_Click(object sender, EventArgs e)
        {
            ListMatpel.deleteMatpelByKode(detKode, detNama);
            tampilSemua();
        }

        //Guru
        private void B_TambahGuru_Click(object sender, EventArgs e)
        {
            using (Frm_Guru sFrmGuru = new Frm_Guru())
            {
                if (sFrmGuru.ShowDialog() == DialogResult.OK)
                {
                    tampilSemua();
                }
            }

        }
        private void B_EditGuru_Click(object sender, EventArgs e)
        {
            using (Frm_Guru aFrmGuru = new Frm_Guru(detKode, detNama))
            {
                if (aFrmGuru.ShowDialog() == DialogResult.OK)
                {
                    tampilSemua();
                }
            }
        }
        private void B_HapusGuru_Click(object sender, EventArgs e)
        {
            ListGuru.deleteGuruByKode(detKode, detNama);
            tampilSemua();
        }


        //Kelas
        private void B_TambahKelas_Click(object sender, EventArgs e)
        {
            using (Frm_Kelas aFrmKelas = new Frm_Kelas())
            {
                if (aFrmKelas.ShowDialog() == DialogResult.OK)
                {
                    tampilSemua();
                }
            }
        }
        private void B_EditKelas_Click(object sender, EventArgs e)
        {
            using (Frm_Kelas aFrmKelas = new Frm_Kelas(detKode))
            {
                if (aFrmKelas.ShowDialog() == DialogResult.OK)
                {
                    tampilSemua();
                }
            }
        }
        private void B_HapusKelas_Click(object sender, EventArgs e)
        {
            ListKelas.deleteKelasByNama(detKode);
            tampilSemua();
        }

        //Tugas
        private void B_TambahTugas_Click(object sender, EventArgs e)
        {
            using (Frm_Tugas aFrmTugas = new Frm_Tugas())
            {
                if (aFrmTugas.ShowDialog() == DialogResult.OK)
                {
                    tampilSemua();
                }
            }
        }
        private void B_EditTugas_Click(object sender, EventArgs e)
        {
            using (Frm_Tugas aFrmTugas = new Frm_Tugas(detKode, jatahJamTugas))
            {
                if (aFrmTugas.ShowDialog() == DialogResult.OK)
                {
                    tampilSemua();
                }
            }
        }
        private void B_HapusTugas_Click(object sender, EventArgs e)
        {
            ListTugas.deleteTugasByKode(detKode, jatahJamTugas);
            tampilSemua();
        }

        //Save
        private void B_Save_Click(object sender, EventArgs e)
        {
            string savedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Scheduler";
            string path = $"{savedPath}\\Scheduler.txt";
            string jsonMatpel = "null", jsonGuru = "null", jsonKelas = "null", jsonTugas = "null", jsonAll = "";

            DialogResult confirm = MessageBox.Show("Proses ini akan menimpa data simpanan sebelumnya\n" +
                "Lanjutkan menyimpan?", "Save Activity", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    if (!System.IO.File.Exists(path))
                    {
                        System.IO.Directory.CreateDirectory(savedPath);
                    }

                    jsonMatpel = JsonConvert.SerializeObject(ListMatpel.getList().ToArray());
                    jsonGuru = JsonConvert.SerializeObject(ListGuru.getList().ToArray());
                    jsonKelas = JsonConvert.SerializeObject(ListKelas.getList().ToArray());
                    jsonTugas = JsonConvert.SerializeObject(ListTugas.getList().ToArray());

                    jsonAll = $"{jsonMatpel}\r\n{jsonGuru}\r\n{jsonKelas}\r\n{jsonTugas}";
                    System.IO.File.WriteAllText(path, jsonAll);
                    MessageBox.Show("Berhasil menyimpan pada " + path, "Save Succes");
                }
                catch
                {
                    MessageBox.Show("Tidak berhasil menyimpan\n" +
                        "Terjadi Kesalahan saat menyimpan data", "Error");
                }
            }
        }

        //Load
        private void B_Load_Click(object sender, EventArgs e)
        {
            string loadPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = $"{loadPath}\\Scheduler\\Scheduler.txt";

            DialogResult confirm = MessageBox.Show("Proses ini akan memuat data simpanan pada\n"
                + path + "\nTetap lanjutkan?", "Load Activity", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string dataFile = System.IO.File.ReadAllText(path);
                    string[] chunkFile = dataFile.Split('\n');
                    List<M_Matpel> tempMatpel = JsonConvert.DeserializeObject<List<M_Matpel>>(chunkFile[0]);
                    ListMatpel.clearList();
                    foreach (M_Matpel matpel in tempMatpel)
                        ListMatpel.addToList(matpel);

                    List<M_Guru> tempGuru = JsonConvert.DeserializeObject<List<M_Guru>>(chunkFile[1]);
                    ListGuru.clearList();
                    foreach (M_Guru guru in tempGuru)
                        ListGuru.addToList(guru);

                    List<M_Kelas> tempKelas = JsonConvert.DeserializeObject<List<M_Kelas>>(chunkFile[2]);
                    ListKelas.clearList();
                    foreach (M_Kelas kelas in tempKelas)
                        ListKelas.addToList(kelas);

                    List<M_Tugas> tempTugas = JsonConvert.DeserializeObject<List<M_Tugas>>(chunkFile[3]);
                    ListTugas.clearList();
                    foreach (M_Tugas tugas in tempTugas)
                        ListTugas.addToList(tugas);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    tampilSemua();
                }
            }
        }

        //Execute
        private void B_Execute_Click(object sender, EventArgs e)
        {
            DialogResult show = MessageBox.Show("Proses akan memakan waktu cukup lama\n" +
                "Tetap lanjutkan?", "Execute", MessageBoxButtons.YesNo);
            if (show == DialogResult.Yes)
            {
                int populasi = 100, iterasi = 10;
                float cross = 0.7f, mutationr = 0.3f;
                Frm_Proses showProses = new Frm_Proses();
                try
                {
                    //inisiasi
                    showProses.Show();
                    showProses.GantiLabel("Inisiasi data");
                    initiateAll();
                    Population1 semua = new Population1(populasi, cross, mutationr);
                    //mulai program
                    int x = 0;
                    showProses.GantiLabel("Memulai program utama");
                    while ((x < iterasi)/* && (semua.poparr[0].fitness < 50)*/)
                    {
                        semua.evolve();
                        //Console.WriteLine(semua.poparr[0].fitness); //cek fitnes
                        showProses.GantiLabel($"{(x * 100) / iterasi}% Complete");
                        x++;
                    }
                    //hasil nya di have
                    showProses.Close();
                    Room[] hasil = semua.poparr[0].ruang();
                    Console.WriteLine("Berhasil denganperhitungan " + semua.poparr[0].fitness); //debug
                    Home.PAB.showUC_Hasil(hasil);
                }
                catch
                {
                    showProses.Close();
                    MessageBox.Show("Proses tidak dapat dijalankan. kemungkinan:\n" +
                        "1. Data kurang lengap");
                }
            }
        }

        //initiater
        public static void initiateAll()
        {
            deleteAllInAprioriGA();
            Waktu.initiate();
            ClassRoom.instalKelas(ListKelas.getList());
            Room.instalkelas();
            Mapel.instalMapel(ListTugas.getList());
            MTC.instalMapel(ListTugas.getList());
            MGMP.instalMGMP(ListGuru.getList());
            allCSPDB.instalkelas();
        }

        public static void deleteAllInAprioriGA()
        {
            Waktu.Data = null;
            ClassRoom.data = null;
            Room.Data = null;
            Mapel.data = null;
            MTC.Data = null;
            MGMP.Data = null;
            allCSPDB.hasil = null;
        }

        //method nampilin
        private void tampilMatpel()
        {
            string waktu;
            GridView_Matpel.Rows.Clear();

            foreach (M_Matpel data in ListMatpel.getList())
            {
                waktu = data.waktuDiadakan ? "Pagi" : "Siang";

                GridView_Matpel.Rows.Add(data.namaMatpel, data.kodeMatpel, data.jenisMatpel, waktu);
            }
        }
        private void tampilGuru()
        {
            string hari;
            GridView_Guru.Rows.Clear();

            foreach (M_Guru data in ListGuru.getList())
            {
                hari = data.mgmp.Equals(0) ? "Tidak Ada" : data.mgmp.Equals(1) ? "Senin"
                    : data.mgmp.Equals(2) ? "Selasa" : data.mgmp.Equals(3) ? "Rabu"
                    : data.mgmp.Equals(4) ? "Kamis" : data.mgmp.Equals(5) ? "Jumat"
                    : data.mgmp.Equals(6) ? "Sabtu" : "-";

                GridView_Guru.Rows.Add(data.namaGuru, data.kodeGuru, hari);
            }
        }
        private void tampilKelas()
        {
            GridView_Kelas.Rows.Clear();

            foreach (M_Kelas data in ListKelas.getList())
            {
                GridView_Kelas.Rows.Add(data.namaKelas, data.angkatan, data.jenis);
            }
        }
        private void tampilTugas()
        {
            GridView_Tugas.Rows.Clear();

            foreach (M_Tugas data in ListTugas.getList())
            {
                string kelas = string.Join(", ", data.jatahKelas);
                GridView_Tugas.Rows.Add(data.guru.namaGuru, data.matpel.namaMatpel, data.kodeTugas,
                    data.jatahJam, kelas);
            }
        }
        private void tampilSemua()
        {
            tampilMatpel();
            tampilGuru();
            tampilKelas();
            tampilTugas();
        }

        //menentukan determinant
        private void GridView_Matpel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            B_EditMatpel.Enabled = true;
            B_HapusMatpel.Enabled = true;
            if (e.RowIndex >= 0)
                rowSelected = GridView_Matpel.Rows[e.RowIndex];

            detKode = rowSelected.Cells[1].Value.ToString();
            detNama = rowSelected.Cells[0].Value.ToString();
        }
        private void GridView_Guru_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            B_EditGuru.Enabled = true;
            B_HapusGuru.Enabled = true;
            if (e.RowIndex >= 0)
                rowSelected = GridView_Guru.Rows[e.RowIndex];

            detKode = rowSelected.Cells[1].Value.ToString();
            detNama = rowSelected.Cells[0].Value.ToString();
        }
        private void GridView_Kelas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            B_EditKelas.Enabled = true;
            B_HapusKelas.Enabled = true;
            if (e.RowIndex >= 0)
                rowSelected = GridView_Kelas.Rows[e.RowIndex];

            detKode = rowSelected.Cells[0].Value.ToString();
        }
        private void GridView_Tugas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            B_EditTugas.Enabled = true;
            B_HapusTugas.Enabled = true;
            if (e.RowIndex >= 0)
                rowSelected = GridView_Tugas.Rows[e.RowIndex];

            detKode = rowSelected.Cells[2].Value.ToString();
            jatahJamTugas = int.Parse(rowSelected.Cells[3].Value.ToString());
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            GridView_Matpel.ClearSelection();
            B_EditMatpel.Enabled = false;
            B_HapusMatpel.Enabled = false;

            GridView_Guru.ClearSelection();
            B_EditGuru.Enabled = false;
            B_HapusGuru.Enabled = false;

            GridView_Kelas.ClearSelection();
            B_EditKelas.Enabled = false;
            B_HapusKelas.Enabled = false;

            GridView_Tugas.ClearSelection();
            B_EditTugas.Enabled = false;
            B_HapusTugas.Enabled = false;
        }

    }
}
