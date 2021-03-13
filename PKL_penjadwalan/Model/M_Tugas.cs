using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKL_penjadwalan.Model
{
    public class M_Tugas
    {
        public M_Guru guru { set; get; }
        public M_Matpel matpel { set; get; }
        public string kodeTugas { set; get; }
        public int jatahJam { set; get; }
        public List<string> jatahKelas { set; get; }

        public M_Tugas() { }

        public M_Tugas(string kodeGuru, string namaGuru, string kodeMatpel, string namaMatpel, int jam, List<string> kelas)
        {
            this.guru = ListGuru.getGuruByKode(kodeGuru, namaGuru);
            this.matpel = ListMatpel.getMatpelByKode(kodeMatpel, namaMatpel);
            this.kodeTugas = $"{guru.kodeGuru} {kodeMatpel}";
            this.jatahJam = jam;
            this.jatahKelas = kelas;
        }
    }
}
