using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKL_penjadwalan.Model
{
    public class M_Guru
    {
        public string namaGuru { set; get; }
        public string kodeGuru { set; get; }
        public int mgmp { set; get; }
        
        public M_Guru() { }

        public M_Guru(string nama, string kode, int mgmp)
        {
            this.namaGuru = nama;
            this.kodeGuru = kode;
            this.mgmp = mgmp;
        }
    }
}
