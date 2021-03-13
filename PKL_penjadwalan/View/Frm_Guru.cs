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
    public partial class Frm_Guru : Form
    {
        private M_Guru oldDataGuru;

        public Frm_Guru()
        {
            InitializeComponent();
        }

        public Frm_Guru(string oldKode, string oldNama)
        {
            InitializeComponent();
            
            oldDataGuru = ListGuru.getGuruByKode(oldKode, oldNama);

            TB_KodeGuru.Text = oldDataGuru.kodeGuru;
            TB_namaGuru.Text = oldDataGuru.namaGuru;
            CB_MGMP.SelectedIndex = oldDataGuru.mgmp;
        }

        private void Btn_OKGuru_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TB_namaGuru.Text) && !String.IsNullOrWhiteSpace(TB_KodeGuru.Text))
            {
                string nama = TB_namaGuru.Text;
                string kode = TB_KodeGuru.Text;
                int mgmp = CB_MGMP.SelectedIndex;

                if (oldDataGuru == null)
                {
                    ListGuru.addToList(new M_Guru(nama, kode, mgmp));
                }
                else
                {
                    ListGuru.editGuruByKode(oldDataGuru.kodeGuru, oldDataGuru.namaGuru, new M_Guru(nama, kode, mgmp));
                }
            }
            else
            {
                MessageBox.Show("Silahkan lengkapi data yang dibutuhkan", "Data Belum Lengkap");
            }
        }
    }
}
