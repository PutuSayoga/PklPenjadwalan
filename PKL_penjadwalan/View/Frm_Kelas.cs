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
    public partial class Frm_Kelas : Form
    {
        protected M_Kelas oldDataKelas;

        public Frm_Kelas()
        {
            InitializeComponent();
        }

        public Frm_Kelas(string oldNama)
        {
            InitializeComponent();

            oldDataKelas = ListKelas.getKelasByNama(oldNama);
            if (oldDataKelas != null)
            {
                TB_NamaKls.Text = oldDataKelas.namaKelas;
                if (oldDataKelas.angkatan == "10")
                    RB_10.Checked = true;
                else if (oldDataKelas.angkatan == "11")
                    RB_11.Checked = true;
                else
                    RB_12.Checked = true;
                CB_Kls.SelectedItem = oldDataKelas.jenis;
            }
        }

        private void Btn_OKKls_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TB_NamaKls.Text) && (RB_10.Checked == true || RB_11.Checked == true
                || RB_12.Checked == true) && !String.IsNullOrWhiteSpace(CB_Kls.Text))
            {
                string nama = TB_NamaKls.Text;
                string angkatan = RB_10.Checked == true ? RB_10.Text :
                    RB_11.Checked == true ? RB_11.Text : RB_12.Text;
                string jenis = CB_Kls.Text;

                if (oldDataKelas == null)
                {
                    ListKelas.addToList(new M_Kelas(nama, angkatan, jenis));
                }
                else
                {
                    ListKelas.editKelasByNama(oldDataKelas.namaKelas, new M_Kelas(nama, angkatan, jenis));
                }
            }
            else
            {
                MessageBox.Show("Silahkan lengkapi data yang dibutuhkan", "Data Belum Lengkap");
            }
        }
    }
}
