using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKL_penjadwalan.GUI
{
    public partial class Frm_Proses : Form
    {
        public Frm_Proses()
        {
            InitializeComponent();
        }

        public void GantiLabel(string pesan)
        {
            label1.Text = pesan;
            this.Refresh();
        }
    }
}
