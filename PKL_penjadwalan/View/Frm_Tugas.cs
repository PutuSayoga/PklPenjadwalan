using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKL_penjadwalan.Model;

namespace PKL_penjadwalan.GUI
{
    public partial class Frm_Tugas : Form
    {
        private M_Tugas oldDataTugas;

        public Frm_Tugas()
        {
            InitializeComponent();
            setComboBoxGuru();
            setComboBoxMatpel();
            setCheckList();
        }

        public Frm_Tugas(string kode, int jam)
        {
            InitializeComponent();
            setComboBoxGuru();
            setComboBoxMatpel();
            setCheckList();

            oldDataTugas = ListTugas.getTugasByKode(kode, jam);
            if (oldDataTugas != null)
            {
                CB_NamaGuru.SelectedItem = $"{oldDataTugas.guru.kodeGuru} | {oldDataTugas.guru.namaGuru}";
                CB_NamaMatpel.SelectedItem = $"{oldDataTugas.matpel.kodeMatpel} | {oldDataTugas.matpel.namaMatpel}";
                CB_jam.SelectedItem = oldDataTugas.jatahJam.ToString();
                for(int i = 0; i < CL_Kelas.Items.Count; i++)
                {
                    for(int j = 0; j<oldDataTugas.jatahKelas.Count; j++)
                    {
                        if (CL_Kelas.Items[i].ToString() == oldDataTugas.jatahKelas[j])
                        {
                            CL_Kelas.SetItemChecked(i, true);
                        }
                    }
                }
            }

        }

        private void Btn_OKTgs_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(CB_NamaGuru.Text) && !String.IsNullOrWhiteSpace(CB_NamaMatpel.Text)
                && !string.IsNullOrWhiteSpace(CB_jam.Text))
            {
                string kodeGuru, namaGuru, kodeMatpel, namaMatpel;
                string[] guru = CB_NamaGuru.Text.Split('|');
                kodeGuru = guru[0].Trim();
                namaGuru = guru[1].Trim();
                string[] matpel = CB_NamaMatpel.Text.Split('|');
                kodeMatpel = matpel[0].Trim();
                namaMatpel = matpel[1].Trim();
                int jam = int.Parse(CB_jam.Text);
                List<string> kelas = new List<string>();
                foreach(var item in CL_Kelas.CheckedItems)
                {
                    kelas.Add(item.ToString());
                }
                if (oldDataTugas == null)
                {
                    ListTugas.addToList(new M_Tugas(kodeGuru, namaGuru, kodeMatpel, namaMatpel, jam, kelas));
                }
                else
                {
                    ListTugas.editTugasByKode(oldDataTugas.kodeTugas, oldDataTugas.jatahJam,
                        new M_Tugas(kodeGuru, namaGuru, kodeMatpel, namaMatpel, jam, kelas));
                }
            }
            else
            {
                MessageBox.Show("Silahkan lengkapi data yang dibutuhkan", "Data Belum Lengkap");
            }
        }

        private void setComboBoxGuru()
        {
            List<M_Guru> listGuru = ListGuru.getList();
            if (!listGuru.Count.Equals(0))
            {
                L_ErrorGuru.Visible = false;
                CB_NamaGuru.Visible = true;
                foreach(M_Guru guru in listGuru)
                {
                    CB_NamaGuru.Items.Add($"{guru.kodeGuru} | {guru.namaGuru}");
                }
            }
            else
            {
                CB_NamaGuru.Visible = false;
                L_ErrorGuru.Visible = true;

                L_ErrorGuru.Text = $"*Data guru belum terisi\n Silahkan mengisi data guru pada tab guru";
            }
        }
        private void setComboBoxMatpel()
        {
            List<M_Matpel> listMatpel = ListMatpel.getList();
            if (!listMatpel.Count.Equals(0))
            {
                L_ErrorMatpel.Visible = false;
                CB_NamaMatpel.Enabled = true;
                foreach (M_Matpel matpel in listMatpel)
                {
                    CB_NamaMatpel.Items.Add($"{matpel.kodeMatpel} | {matpel.namaMatpel}");
                }
            }
            else
            {
                CB_NamaMatpel.Visible = false;
                L_ErrorMatpel.Visible = true;
                L_ErrorMatpel.Text = $"*Data guru belum terisi\n Silahkan mengisi data guru pada tab guru";
            }
        }
        private void setCheckList()
        {
            List<M_Kelas> listKelas = ListKelas.getList();
            if (!listKelas.Count.Equals(0))
            {
                L_ErrorKelas.Visible = false;
                CL_Kelas.Enabled = true;
                foreach (M_Kelas kelas in listKelas)
                {
                    CL_Kelas.Items.Add(kelas.namaKelas);
                }
            }
            else
            {
                L_ErrorKelas.Visible = true;
                CL_Kelas.Enabled = false;
            }
        }
    }
}
