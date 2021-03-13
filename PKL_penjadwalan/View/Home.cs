using AprioriGA;
using PKL_penjadwalan.GUI;
using PKL_penjadwalan.GUI.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKL_penjadwalan
{
    public partial class Home : Form
    {
        int PanelWidth, state;
        bool isColapsed;
        public static Home PAB;

        public Home()
        {
            InitializeComponent();
            PanelWidth = panelDasboard.Width;
            isColapsed = false;
            state = 0;
            PAB = this;
        }

        private void B_UC_IsiSK_Click(object sender, EventArgs e)
        {
            if (state != 1)
            {
                PenunjukDashboard(B_UC_IsiSK);
                UC_IsiSK anIsiSK = new UC_IsiSK();
                AddControlToBody(anIsiSK);
                state = 1;
            }
        }
        
        private void B_UC_Hasil_Click(object sender, EventArgs e)
        {
            if (state != 2)
            {
                PenunjukDashboard(B_UC_Hasil);
                UC_Hasil aHasil = new UC_Hasil();
                AddControlToBody(aHasil);
                state = 2;
            }
        }

        public void showUC_Hasil(Room[] hasil)
        {
            PenunjukDashboard(B_UC_Hasil);
            UC_Hasil aHasil = new UC_Hasil(hasil);
            AddControlToBody(aHasil);
            state = 2;
        }

        //Geser Dashboard
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isColapsed)
            {
                panelDasboard.Width = panelDasboard.Width + 10;
                if (panelDasboard.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isColapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelDasboard.Width = panelDasboard.Width - 10;
                if (panelDasboard.Width <= 60)
                {
                    timer1.Stop();
                    isColapsed = true;
                    this.Refresh();
                }
            }
        }

        private void GeserDasboard(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //Penunjuk
        private void PenunjukDashboard(Control btn)
        {
            panelSlide.Visible = true;
            panelSlide.Top = btn.Top - 5;
        }

        //Ganti tampilan
        public void AddControlToBody(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        //Exit App
        private void ExitApp_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to Close?", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
                Application.Exit();
        }
    }
}
