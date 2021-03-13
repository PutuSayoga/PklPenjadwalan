using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKL_penjadwalan.Model
{
    public class M_Kelas
    {
        public string namaKelas { set; get; }
        public string angkatan { set; get; }
        public string jenis { set; get; }

        public M_Kelas() { }

        public M_Kelas(string nama, string angkt, string jns)
        {
            this.namaKelas = nama;
            this.angkatan = angkt;
            this.jenis = jns;
        }
    }
}
