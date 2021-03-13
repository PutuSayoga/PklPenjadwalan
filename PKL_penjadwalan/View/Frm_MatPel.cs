using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKL_penjadwalan.GUI.Control;
using PKL_penjadwalan.Model;

namespace PKL_penjadwalan.GUI
{
    public partial class Frm_MatPel : Form
    {
        private M_Matpel oldDataMatpel;

        public Frm_MatPel()
        {
            InitializeComponent();
        }

        public Frm_MatPel(string kode, string oldNama)
        {
            InitializeComponent();
            
            oldDataMatpel = ListMatpel.getMatpelByKode(kode, oldNama);
            if (oldDataMatpel != null)
            {
                TB_KodeMatpel.Text = oldDataMatpel.kodeMatpel;
                TB_NamMatpel.Text = oldDataMatpel.dasarMatpel;
                CB_Matpel.SelectedItem = oldDataMatpel.jenisMatpel;
                if (oldDataMatpel.waktuDiadakan == true)
                    RB_Pagi.Checked = true;
                else
                    RB_Siang.Checked = true;
            }
        }

        private void Btn_OKMtpl_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TB_NamMatpel.Text) && !String.IsNullOrWhiteSpace(TB_KodeMatpel.Text)
                && !String.IsNullOrWhiteSpace(CB_Matpel.Text) && (RB_Pagi.Checked == true || RB_Siang.Checked == true))
            {
                string nama = TB_NamMatpel.Text;
                string kode = TB_KodeMatpel.Text;
                string jenis = CB_Matpel.SelectedItem.ToString();
                bool waktu = RB_Pagi.Checked ? true : false;

                if (oldDataMatpel == null)
                {
                    ListMatpel.addToList(new M_Matpel(kode, nama, jenis, waktu));
                }
                else
                {
                    ListMatpel.editMatpelByKode(oldDataMatpel.kodeMatpel, oldDataMatpel.namaMatpel, new M_Matpel(kode, nama, jenis, waktu));
                }
                
            }
            else
            {
                MessageBox.Show("Silahkan lengkapi data yang dibutuhkan", "Data Belum Lengkap");
            }
        }
    }
}
