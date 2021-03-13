using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKL_penjadwalan.Model
{
    public class M_Matpel
    {
        public string kodeMatpel { set; get; }
        public string dasarMatpel { set; get; }
        public string jenisMatpel { set; get; }
        public string namaMatpel { set; get; }
        public bool waktuDiadakan { set; get; }

        public M_Matpel() { }

        public M_Matpel(string kode, string dasar, string jenis, bool waktu)
        {
            this.kodeMatpel = kode;
            this.dasarMatpel = dasar;
            this.jenisMatpel = jenis;
            this.waktuDiadakan = waktu;
            this.namaMatpel = jenis == "Wajib" ? dasarMatpel : jenis == "Minat" ? $"{dasarMatpel} Peminatan" : $"Lintas Minat {dasar}";
        }
    }
}
