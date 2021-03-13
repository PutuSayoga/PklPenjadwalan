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
    public partial class Frm_Legend : Form
    {
        private static Frm_Legend instance;

        public Frm_Legend()
        {
            InitializeComponent();
        }

        public static void showForm()
        {
            if (instance==null)
            {
                instance = new Frm_Legend();
                instance.Show();
            }
            else
            {
                instance.BringToFront();
            }
        }

        private void Frm_Legend_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void Frm_Legend_Load(object sender, EventArgs e)
        {
            //Ket guru
            foreach (M_Guru guru in ListGuru.getList())
            {
                GridViewShow_Guru.Rows.Add(guru.kodeGuru, guru.namaGuru);
            }

            //ket matpel
            foreach(M_Matpel matpel in ListMatpel.getList())
            {
                GridViewShow_Matpel.Rows.Add(matpel.kodeMatpel, matpel.namaMatpel);
            }

            //Ket mgmp
            string[] hari = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
            List<string> senin, selasa, rabu, kamis, jumat, sabtu;
            senin = new List<string>();
            selasa = new List<string>();
            rabu = new List<string>();
            kamis = new List<string>();
            jumat = new List<string>();
            sabtu = new List<string>();

            foreach(M_Guru guru in ListGuru.getList())
            {
                if (guru.mgmp.Equals(1))
                {
                    senin.Add(guru.kodeGuru);
                }
                else if (guru.mgmp.Equals(2))
                {
                    selasa.Add(guru.kodeGuru);
                }
                else if (guru.mgmp.Equals(3))
                {
                    rabu.Add(guru.kodeGuru);
                }
                else if (guru.mgmp.Equals(4))
                {
                    kamis.Add(guru.kodeGuru);
                }
                else if (guru.mgmp.Equals(5))
                {
                    jumat.Add(guru.kodeGuru);
                }
                else if (guru.mgmp.Equals(6))
                {
                    sabtu.Add(guru.kodeGuru);
                }
            }

            string[] hariMGMP = new string[6];
            hariMGMP[0] = string.Join(", ", senin);
            hariMGMP[1] = string.Join(", ", selasa);
            hariMGMP[2] = string.Join(", ", rabu);
            hariMGMP[3] = string.Join(", ", kamis);
            hariMGMP[4] = string.Join(", ", jumat);
            hariMGMP[5] = string.Join(", ", sabtu);

            for (int i = 0; i<hari.Length; i++)
            {
                GridViewShow_MGMP.Rows.Add(hari[i], hariMGMP[i]);
            }

            setColumnsMode(GridViewShow_MGMP, DataGridViewColumnSortMode.NotSortable);
        }

        private static void setColumnsMode(DataGridView instance, DataGridViewColumnSortMode sortMode)
        {
            for(int i = 0; i<instance.ColumnCount; i++)
            {
                instance.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
