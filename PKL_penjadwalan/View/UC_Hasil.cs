using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AprioriGA;
using Newtonsoft.Json;

namespace PKL_penjadwalan.GUI.Control
{
    public partial class UC_Hasil : UserControl
    {
        static Room[] olahanData;

        public UC_Hasil()
        {
            InitializeComponent();
        }

        public UC_Hasil(Room[] hasil)
        {
            InitializeComponent();
            olahanData = hasil;
        }

        private void UC_Hasil_Load(object sender, EventArgs e)
        {
            if (olahanData != null)
            {
                label2.Visible = false;
                DataTable dt = new DataTable();
                DataRow dr;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = dt;

                //set header
                dt.Columns.Add("Hari");
                dt.Columns.Add("Jam");
                for (int i = 0; i < ClassRoom.data.Count; i++)
                {
                    dt.Columns.Add(ClassRoom.data.ElementAt(i).name);
                }

                //ulang perhari
                for (int hari = 0; hari < 5; hari++)
                {
                    //ulang perjam
                    for (int jam = 0; jam < 12; jam++)
                    {
                        dr = dt.NewRow();
                        if (jam < 11)
                        {
                            if (hari == 0)
                                dr[0] = "Senin";
                            else if (hari == 1)
                                dr[0] = "Selasa";
                            else if (hari == 2)
                                dr[0] = "Rabu";
                            else if (hari == 3)
                                dr[0] = "Kamis";
                            else if (hari == 4)
                                dr[0] = "Jumat";

                            dr[1] = jam + 1;
                        }
                        //ulang seluruh olahanData kemudian dicocokin dengan cellnya
                        for (int repeat = 0; repeat < olahanData.Length; repeat++)
                        {
                            //ulang perkelas => aktivitas mencocokkan
                            for (int i = 0; i < ClassRoom.data.Count(); i++)
                            {
                                if (olahanData[repeat].wkt.day.Equals(hari + 1) &&
                                    olahanData[repeat].wkt.hour.Equals(jam + 1) &&
                                    olahanData[repeat].roomclass.name.Equals(dataGridView1.Columns[i + 2].HeaderText))
                                {
                                    dr[i + 2] = olahanData[repeat].mapel.IdTeacher;
                                }
                            }
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            else
            {
                label2.Text = "Hasil jadwal belum tersedia\n" +
                    "Silahkan isi data SK\n" +
                    "Kemudian klik tombol execute pada tab Tugas";
                label2.Visible = true;
            }

            setColumnsMode(dataGridView1, DataGridViewColumnSortMode.NotSortable);
        }

        private static void setColumnsMode(DataGridView instance, DataGridViewColumnSortMode sortMode)
        {
            for (int i = 0; i < instance.ColumnCount; i++)
            {
                instance.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void B_Excel_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Rencana jadwal MatPel";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tidak bisa melakukan export ke Microsoft Excel. Kemungkinan:\n" +
                    "1. Microsoft Excel tidak terinstal\n" + $"2. {ex.Message}", "Error");
            }
        }

        private void B_Legend_Click(object sender, EventArgs e)
        {
            Frm_Legend.showForm();
        }
    }
}
