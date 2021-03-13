using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKL_penjadwalan.Model;

namespace AprioriGA
{
    public class Mapel
    {
        public static LinkedList<Mapel> data;
        //ganti jadi angka plus a dan b
        public String IdTeacher;
        //nama mapelnya
        public String lessonName;
        public String Dasar;
        // true untuk pagi
        //false untuk siang diatas jam 12
        public bool dificulty;

        public Mapel(String tc,String da,String less, Boolean diff)
        {
            if (data == null)
            {
                data = new LinkedList<Mapel>();
            }
            Dasar = da;
            IdTeacher = tc;
            lessonName = less;
            dificulty = diff;
            data.AddLast(this);
        }
        public static String getbasicbyID(String id)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data.ElementAt(i).IdTeacher == id)
                {
                    return data.ElementAt(i).Dasar;
                }
            }
            return null;
        }

        public static Mapel[] getAllMapel()
        {
            LinkedList<Mapel> all=new LinkedList<Mapel>();
            for (int i=0;i<data.Count;i++)
            {
                all.AddLast(data.ElementAt(i));
            }
            return all.ToArray();
        }

        public static Mapel[] getDayMapel(int day)
        {
            LinkedList<Mapel> ro = new LinkedList<Mapel>();
            String[] da = MGMP.getDayMGMP(day);
            for (int i = 0; i < data.Count; i++)
            {
                String[] dt = data.ElementAt(i).IdTeacher.Split(' ');
                bool x = true;
                for (int j=0;((j<da.Length) && x);j++)
                {
                    if (dt[0] == da[j])
                    {
                        x = false;
                        j = da.Length - 1;
                        break;
                    }
                    else if((j==(da.Length-1))&&(x==true))
                    {
                        ro.AddLast(data.ElementAt(i));
                    }
                }
            }
            return data.Except(ro).ToArray();
        }
        // masih error
        public static Mapel[] getdayMTCmapel(String kls,int d)
        {
            LinkedList<Mapel> hasil = MTC.getDaftarMapel(kls);
            List<String> hasilisi=new List<string>();
            String[] da = MGMP.getDayMGMP(d);

            for (int i = 0; i < hasil.Count; i++)
            {
                String[] dt = data.ElementAt(i).IdTeacher.Split(' ');
                hasilisi.Add(dt[0]);
            }
            hasilisi = hasilisi.Intersect(da).ToList();
            List<int> hapus = new List<int>();
            for (int i = hasil.Count; i > -1; i++)
            {
                if(hasilisi.Contains(hasil.ElementAt(i).IdTeacher.Split(' ')[0]))
                {
                    hapus.Add(i);
                    hasil.Remove(hasil.ElementAt(i));
                }
            }
            return hasil.ToArray();
        }

        public static Mapel getMapelbyID(String id)
        {
            for(int i = 0; i < data.Count; i++)
            {
                if (data.ElementAt(i).IdTeacher == id)
                {
                    return data.ElementAt(i);
                }
            }
            return null;
        }

        public static bool GetDiffbyID(String id)
        {
            for(int i = 0; i < data.Count; i++)
            {
                if (data.ElementAt(i).IdTeacher == id)
                {
                    return data.ElementAt(i).dificulty;
                }
            }
            return false;
        }
        public static int GetIndexbyID(String ID)
        {
            int a = -1;
            for(int i = 0; i < data.Count; i++)
            {
                if (data.ElementAt(i).IdTeacher == ID)
                {
                    a = i;
                    i = data.Count;
                }
            }
            return a;
        }

        //tambaan
        public static void instalMapel(List<M_Tugas> listTugas)
        {
            foreach(M_Tugas tugas in listTugas)
            {
                new Mapel(tugas.kodeTugas, tugas.matpel.dasarMatpel, tugas.matpel.namaMatpel, tugas.matpel.waktuDiadakan);
            }
        }

        public static void initiate()
        {
            new Mapel("2", "Prakarya dan Kewirausahaan", "Prakarya dan Kewirausahaan", false);
            new Mapel("3 A", "Bahasa Inggris", "Bahasa Inggris", true);
            new Mapel("3 B", "Bahasa Inggris", "Bahasa Inggris Minat", true);
            new Mapel("4", "Pendidikan Agama Islam", "Pendidikan Agama Islam", false);
            new Mapel("5", "Fisika", "Fisika", true);//5
            new Mapel("6 A", "Ekonomi", "Ekonomi", true);
            new Mapel("6 B", "Ekonomi", "Ekonomi Minat", true);
            new Mapel("7", "Sosiologi dan Antropologi", "Sosiologi dan Antropologi", false);
            new Mapel("8", "Pkn", "Pkn", false);
            new Mapel("9 A", "Bahasa Jerman", "Bahasa Jerman Minat", false);//10
            new Mapel("9 B", "Bahasa Daerah", "Bahasa Daerah", false);
            new Mapel("10 A", "Bahasa Inggris", "Bahasa Inggris", false);
            new Mapel("10 B", "Bahasa Inggris", "Bahasa Inggris Minat", false);
            new Mapel("11", "Bahasa Indonesia", "Bahasa Indonesia", false);
            new Mapel("12", "Matematika", "Matematika Wajib", true);//15
            new Mapel("13", "Kimia", "Kimia", true);
            new Mapel("14", "Biologi", "Biologi", true);
            new Mapel("15", "Biologi", "Biologi", true);
            new Mapel("16", "Matematika", "Matematika Wajib", true);
            new Mapel("17 A", "Ekonomi", "Ekonomi", true);//20
            new Mapel("17 B", "Ekonomi", "Ekonomi Minat", true);
            new Mapel("17 C", "Prakarya dan Kewirausahaan", "Prakarya dan Kewirausahaan", false);
            new Mapel("18", "BP/BK", "BP/BK", false);
            new Mapel("19", "Pendidikan Agama Katolik", "Pendidikan Agama Katolik", false);//25
            new Mapel("20", "Bahasa Indonesia", "Bahasa Indonesia", true);
            new Mapel("21 A", "Sejarah", "Sejarah", true);
            new Mapel("21 B", "Sejarah", "Sejarah Minat", true);
            new Mapel("22 A", "Matematika", "Matematika Wajib", true);
            new Mapel("22 B", "Matematika", "Matematika Minat", true);//30
            new Mapel("23", "Kesenian", "Kesenian", false);
            new Mapel("24", "Bahasa Indonesia", "Bahasa Indonesia", false);
            new Mapel("25 A", "Bahasa Inggris", "Bahasa Inggris", false);
            new Mapel("25 B", "Bahasa Inggris", "Bahasa Inggris Minat", false);
            new Mapel("26 A", "Bahasa Arab", "Bahasa Arab Minat", false);///35
            new Mapel("26 B", "Pendidikan Agama Islam", "Pendidikan Agama Islam", false);
            new Mapel("27", "Kimia", "Kimia", true);
            new Mapel("28 A", "Sejarah", "Sejarah", true);
            new Mapel("28 B", "Sejarah", "Sejarah Minat", true);
            new Mapel("29", "P.Agama dan Budi Pekerti", "P.Agama dan Budi Pekerti", false);//40
            new Mapel("30", "Pendidikan Agama Kristen", "Pendidikan Agama Kristen", false);
            new Mapel("31", "Fisika", "Fisika", true);
            new Mapel("32 A", "Geografi", "Geografi", false);
            new Mapel("32 B", "Geografi", "Geografi Minat", false);
            new Mapel("33", "Penjasorkes", "Penjasorkes", true);//45
            new Mapel("34 A", "Matematika", "Matematika Wajib", true);
            new Mapel("34 B", "Matematika", "Matematika Minat", true);
            new Mapel("35 A", "Matematika", "Matematika Wajib", true);
            new Mapel("35 B", "Matematika", "Matematika Minat", true);
            new Mapel("36 A", "Pkn", "Pkn", false);//50
            new Mapel("36 B", "Sejarah", "Sejarah Wajib", false);
            new Mapel("37", "Penjasorkes", "Penjasorkes", true);
            new Mapel("38", "Seni Budaya", "Seni Budaya", false);
            new Mapel("39", "Bahasa Daerah", "Bahasa Daerah", false);
            new Mapel("41", "BK", "BK", false);//55
            new Mapel("42", "Agama Hindu", "Agama Hindu", false);
            new Mapel("43 A", "Bahasa Indonesia", "Bahasa Indonesia", false);
            new Mapel("43 B", "Lintas Minat", "Lintas Minat", false);
            new Mapel("44 A", "Geografi", "Geografi Minat", false);
            new Mapel("44 B", "Sosiologi dan Antropologi", "Sosiologi dan Antropologi", false);//60
            new Mapel("44 C", "Sejarah", "Sejarah Wajib", true);

            /**
            new Mapel("*", "Acara Spesial", false);
            new Mapel("X", "Smart Al- Quran/ Kitab", false);
            new Mapel("Bimbel", "Bimbel", false);
            new Mapel("Pendalaman Minat", "Pendalaman Minat", false);
            */

        }
    }
}
