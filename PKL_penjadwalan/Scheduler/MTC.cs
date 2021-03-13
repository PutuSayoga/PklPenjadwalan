using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKL_penjadwalan.Model;

namespace AprioriGA
{
    public class MTC
    {
        public static LinkedList<MTC> Data;
        public static LinkedList<String> Limit3;
        public Mapel mapel;
        public ClassRoom klas;
        public int jatah;
        public MTC(Mapel map,ClassRoom kls,int jat)
        {
            if (Data == null)
            {
                Data = new LinkedList<MTC>();
                Limit3 = new LinkedList<string>();
                Limit3.AddLast("37");
            }
            mapel = map;
            klas = kls;
            jatah = jat;
            Data.AddLast(this);
        }

        public static void instalMapel(List<M_Tugas> listTugas)
        {
            foreach (M_Tugas tugas in listTugas)
            {
                for(int i = 0; i < tugas.jatahKelas.Count; i++)
                {
                    new MTC(Mapel.getMapelbyID(tugas.kodeTugas),ClassRoom.getbyId(tugas.jatahKelas[i]) , tugas.jatahJam);
                }
            }
        }

        public static int getJatahMapel(String kode, String kls)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                if ((Data.ElementAt(i).mapel.IdTeacher == kode) && (Data.ElementAt(i).klas.name == kls))
                {
                    return Data.ElementAt(i).jatah;
                }
            }
            return 0;
        }

        public static LinkedList<String> getDaftarMapelbyID(String kls)
        {
            LinkedList<String> daftar = new LinkedList<String>();
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).klas.name == kls)
                {
                    daftar.AddLast(Data.ElementAt(i).mapel.IdTeacher);
                }
            }
            return daftar;
        }

        public static LinkedList<String> getDaftarMapelbyID1(String kls)
        {
            LinkedList<String> daftar = new LinkedList<String>();
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).klas.name == kls)
                {
                    daftar.AddLast(Data.ElementAt(i).mapel.IdTeacher.Split(' ')[0]);
                }
            }
            return daftar;
        }

        public static int gethardmapel(String kls)
        {
            int a = 0;
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).mapel.dificulty && (Data.ElementAt(i).klas.name == kls))
                {
                    a += Data.ElementAt(i).jatah;
                }
            }
            return a;
        }

        public static String[] getTimeMapel(int day,String kelas,int h)
        {
            LinkedList<String> hasil = new LinkedList<string>();
            
            String[] no1 = MGMP.getDayMGMP(day);
            String[] no2 = getDaftarMapelbyID(kelas).ToArray();
            for (int i=0;i<no2.Length;i++)
            {
                bool ada=false;
                for (int j=0;j<no1.Length;j++)
                {
                    if(no2[i].Split(' ')[0] == no1[j])
                    {
                        ada = true;
                        j = no1.Length;
                    }
                }
                if ((!(Mapel.GetDiffbyID(no2[i]) && (h > 7)))&&(day<5))
                {
                    if (ada)
                    {
                        hasil.AddLast(no2[i]);
                    }
                }
                else if ((!(Mapel.GetDiffbyID(no2[i]) && (h > 6))) && (day == 5))
                {
                    if (ada)
                    {
                        hasil.AddLast(no2[i]);
                    }
                }
                ada = false;
            }
            return hasil.ToArray();
        }

        public static String[] getTimeMapel(int day, String kelas)
        {
            LinkedList<String> hasil = new LinkedList<string>();

            String[] no1 = MGMP.getDayMGMP(day);
            String[] no2 = getDaftarMapelbyID(kelas).ToArray();
            for (int i = 0; i < no2.Length; i++)
            {
                bool ada = false;
                for (int j = 0; j < no1.Length; j++)
                {
                    if (no2[i].Split(' ')[0] == no1[j])
                    {
                        ada = true;
                        j = no1.Length;
                    }
                }
                    if (ada)
                    {
                        hasil.AddLast(no2[i]);
                    }
                ada = false;
            }
            return hasil.ToArray();
        }

        public static LinkedList<String> getIDDaftarMapel(String kls)
        {
            LinkedList<String> daftar = new LinkedList<String>();
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).klas.name == kls)
                {
                    for (int j = 0; j < Data.ElementAt(i).jatah; j++)
                    {
                        daftar.AddLast(Data.ElementAt(i).mapel.IdTeacher);
                    }
                }
            }
            return daftar;
        }

        public static LinkedList<Mapel> getDaftarMapel(String kls)
        {
            LinkedList<Mapel> daftar = new LinkedList<Mapel>();
            for(int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).klas.name == kls)
                {
                    for(int j = 0; j < Data.ElementAt(i).jatah; j++)
                    {
                        daftar.AddLast(Data.ElementAt(i).mapel);
                    }
                }
            }
            return daftar;
        }

        public static String[] dua()
        {
            List<String> hasil = new List<string>();
            for(int i = 0; i < Data.Count; i++)
            {
                if((Data.ElementAt(i).jatah==2)||(Data.ElementAt(i).jatah == 4))
                {
                    hasil.Add(Data.ElementAt(i).mapel.IdTeacher);
                }
            }
            return hasil.ToArray();
        }

        //tambahan
        public static void instalMTC(List<M_Tugas> listTugas)
        {

        }

        public static void initiate()
        {
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(0), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(1), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(2), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(3), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(4), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(5), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(6), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(7), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(8), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(9), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(10), 2);
            new MTC(Mapel.data.ElementAt(0), ClassRoom.data.ElementAt(11), 2);

            new MTC(Mapel.data.ElementAt(1), ClassRoom.data.ElementAt(12), 2);
            new MTC(Mapel.data.ElementAt(1), ClassRoom.data.ElementAt(13), 2);
            new MTC(Mapel.data.ElementAt(1), ClassRoom.data.ElementAt(14), 2);
            new MTC(Mapel.data.ElementAt(1), ClassRoom.data.ElementAt(15), 2);
            new MTC(Mapel.data.ElementAt(1), ClassRoom.data.ElementAt(16), 2);
            new MTC(Mapel.data.ElementAt(1), ClassRoom.data.ElementAt(17), 2);

            new MTC(Mapel.data.ElementAt(2), ClassRoom.data.ElementAt(16), 4);

            new MTC(Mapel.data.ElementAt(3), ClassRoom.data.ElementAt(12), 3);
            new MTC(Mapel.data.ElementAt(3), ClassRoom.data.ElementAt(13), 3);
            new MTC(Mapel.data.ElementAt(3), ClassRoom.data.ElementAt(14), 3);
            new MTC(Mapel.data.ElementAt(3), ClassRoom.data.ElementAt(15), 3);
            new MTC(Mapel.data.ElementAt(3), ClassRoom.data.ElementAt(16), 3);
            new MTC(Mapel.data.ElementAt(3), ClassRoom.data.ElementAt(17), 3);

            new MTC(Mapel.data.ElementAt(4), ClassRoom.data.ElementAt(0), 3);
            new MTC(Mapel.data.ElementAt(4), ClassRoom.data.ElementAt(1), 3);
            new MTC(Mapel.data.ElementAt(4), ClassRoom.data.ElementAt(2), 3);
            new MTC(Mapel.data.ElementAt(4), ClassRoom.data.ElementAt(12), 4);//fisika
            new MTC(Mapel.data.ElementAt(4), ClassRoom.data.ElementAt(13), 4);
            new MTC(Mapel.data.ElementAt(4), ClassRoom.data.ElementAt(14), 4);
            new MTC(Mapel.data.ElementAt(4), ClassRoom.data.ElementAt(15), 4);

            new MTC(Mapel.data.ElementAt(5), ClassRoom.data.ElementAt(10), 4);
            new MTC(Mapel.data.ElementAt(5), ClassRoom.data.ElementAt(11), 4);//ekonomi
            new MTC(Mapel.data.ElementAt(5), ClassRoom.data.ElementAt(16), 4);
            new MTC(Mapel.data.ElementAt(5), ClassRoom.data.ElementAt(17), 4);

            new MTC(Mapel.data.ElementAt(6), ClassRoom.data.ElementAt(6), 4); //ekonomi minat
            new MTC(Mapel.data.ElementAt(6), ClassRoom.data.ElementAt(13), 4);

            new MTC(Mapel.data.ElementAt(7), ClassRoom.data.ElementAt(10), 4);
            new MTC(Mapel.data.ElementAt(7), ClassRoom.data.ElementAt(11), 4);//sosiologi dan antropologi
            new MTC(Mapel.data.ElementAt(7), ClassRoom.data.ElementAt(16), 4);
            new MTC(Mapel.data.ElementAt(7), ClassRoom.data.ElementAt(17), 4);

            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(6), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(7), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(8), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(9), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(10), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(11), 2); //Pkn
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(12), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(13), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(14), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(15), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(16), 2);
            new MTC(Mapel.data.ElementAt(8), ClassRoom.data.ElementAt(17), 2);

            new MTC(Mapel.data.ElementAt(9), ClassRoom.data.ElementAt(4), 3);
            new MTC(Mapel.data.ElementAt(9), ClassRoom.data.ElementAt(5), 3);
            new MTC(Mapel.data.ElementAt(9), ClassRoom.data.ElementAt(8), 4);//jerman minat
            new MTC(Mapel.data.ElementAt(9), ClassRoom.data.ElementAt(9), 4);
            new MTC(Mapel.data.ElementAt(9), ClassRoom.data.ElementAt(17), 4);

            new MTC(Mapel.data.ElementAt(10), ClassRoom.data.ElementAt(0), 2);
            new MTC(Mapel.data.ElementAt(10), ClassRoom.data.ElementAt(1), 2);
            new MTC(Mapel.data.ElementAt(10), ClassRoom.data.ElementAt(2), 2);
            new MTC(Mapel.data.ElementAt(10), ClassRoom.data.ElementAt(3), 2);//bahasa daerah
            new MTC(Mapel.data.ElementAt(10), ClassRoom.data.ElementAt(4), 2);
            new MTC(Mapel.data.ElementAt(10), ClassRoom.data.ElementAt(5), 2);

            new MTC(Mapel.data.ElementAt(11), ClassRoom.data.ElementAt(6), 2);
            new MTC(Mapel.data.ElementAt(11), ClassRoom.data.ElementAt(7), 2);
            new MTC(Mapel.data.ElementAt(11), ClassRoom.data.ElementAt(8), 2);//bahasa inggris
            new MTC(Mapel.data.ElementAt(11), ClassRoom.data.ElementAt(9), 2);
            new MTC(Mapel.data.ElementAt(11), ClassRoom.data.ElementAt(10), 2);
            new MTC(Mapel.data.ElementAt(11), ClassRoom.data.ElementAt(11), 2);

            new MTC(Mapel.data.ElementAt(12), ClassRoom.data.ElementAt(10), 4);
            new MTC(Mapel.data.ElementAt(12), ClassRoom.data.ElementAt(11), 4);//bahasa inggris minat
            new MTC(Mapel.data.ElementAt(12), ClassRoom.data.ElementAt(12), 4);

            new MTC(Mapel.data.ElementAt(13), ClassRoom.data.ElementAt(0), 4);
            new MTC(Mapel.data.ElementAt(13), ClassRoom.data.ElementAt(1), 4);
            new MTC(Mapel.data.ElementAt(13), ClassRoom.data.ElementAt(2), 4);//bahasa indonesia
            new MTC(Mapel.data.ElementAt(13), ClassRoom.data.ElementAt(3), 4);

            new MTC(Mapel.data.ElementAt(14), ClassRoom.data.ElementAt(12), 4);
            new MTC(Mapel.data.ElementAt(14), ClassRoom.data.ElementAt(13), 4);
            new MTC(Mapel.data.ElementAt(14), ClassRoom.data.ElementAt(14), 4);//matematika wajib
            new MTC(Mapel.data.ElementAt(14), ClassRoom.data.ElementAt(15), 4);

            new MTC(Mapel.data.ElementAt(15), ClassRoom.data.ElementAt(0), 3);
            new MTC(Mapel.data.ElementAt(15), ClassRoom.data.ElementAt(1), 3);
            new MTC(Mapel.data.ElementAt(15), ClassRoom.data.ElementAt(2), 3);//kimia
            new MTC(Mapel.data.ElementAt(15), ClassRoom.data.ElementAt(3), 3);
            new MTC(Mapel.data.ElementAt(15), ClassRoom.data.ElementAt(8), 4);
            new MTC(Mapel.data.ElementAt(15), ClassRoom.data.ElementAt(9), 4);

            new MTC(Mapel.data.ElementAt(16), ClassRoom.data.ElementAt(2), 3);
            new MTC(Mapel.data.ElementAt(16), ClassRoom.data.ElementAt(3), 3);
            new MTC(Mapel.data.ElementAt(16), ClassRoom.data.ElementAt(12), 4);
            new MTC(Mapel.data.ElementAt(16), ClassRoom.data.ElementAt(13), 4);//biologi
            new MTC(Mapel.data.ElementAt(16), ClassRoom.data.ElementAt(14), 4);
            new MTC(Mapel.data.ElementAt(16), ClassRoom.data.ElementAt(15), 4);

            new MTC(Mapel.data.ElementAt(17), ClassRoom.data.ElementAt(0), 3);
            new MTC(Mapel.data.ElementAt(17), ClassRoom.data.ElementAt(1), 3);
            new MTC(Mapel.data.ElementAt(17), ClassRoom.data.ElementAt(6), 4);
            new MTC(Mapel.data.ElementAt(17), ClassRoom.data.ElementAt(7), 4);//biologi
            new MTC(Mapel.data.ElementAt(17), ClassRoom.data.ElementAt(8), 4);
            new MTC(Mapel.data.ElementAt(17), ClassRoom.data.ElementAt(9), 4);

            new MTC(Mapel.data.ElementAt(18), ClassRoom.data.ElementAt(0), 4);
            new MTC(Mapel.data.ElementAt(18), ClassRoom.data.ElementAt(1), 4);
            new MTC(Mapel.data.ElementAt(18), ClassRoom.data.ElementAt(2), 4);
            new MTC(Mapel.data.ElementAt(18), ClassRoom.data.ElementAt(3), 4);//matematika wajib
            new MTC(Mapel.data.ElementAt(18), ClassRoom.data.ElementAt(4), 4);
            new MTC(Mapel.data.ElementAt(18), ClassRoom.data.ElementAt(5), 4);

            new MTC(Mapel.data.ElementAt(19), ClassRoom.data.ElementAt(4), 3);
            new MTC(Mapel.data.ElementAt(19), ClassRoom.data.ElementAt(5), 3);//ekonomi

            new MTC(Mapel.data.ElementAt(20), ClassRoom.data.ElementAt(0), 3);
            new MTC(Mapel.data.ElementAt(20), ClassRoom.data.ElementAt(1), 3);//ekonomi minat

            new MTC(Mapel.data.ElementAt(21), ClassRoom.data.ElementAt(12), 2);
            new MTC(Mapel.data.ElementAt(21), ClassRoom.data.ElementAt(13), 2);
            new MTC(Mapel.data.ElementAt(21), ClassRoom.data.ElementAt(14), 2);//prakarya dan kewirausahaan
            new MTC(Mapel.data.ElementAt(21), ClassRoom.data.ElementAt(15), 2);
            new MTC(Mapel.data.ElementAt(21), ClassRoom.data.ElementAt(16), 2);
            new MTC(Mapel.data.ElementAt(21), ClassRoom.data.ElementAt(17), 2);

            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(6), 1);
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(7), 1);
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(8), 1);//BP/BK
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(9), 1);
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(10), 1);
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(11), 1);
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(12), 1);
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(13), 1);
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(14), 1);//BP/BK
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(15), 1);
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(16), 1);
            new MTC(Mapel.data.ElementAt(22), ClassRoom.data.ElementAt(17), 1);

            new MTC(Mapel.data.ElementAt(24), ClassRoom.data.ElementAt(12), 4);
            new MTC(Mapel.data.ElementAt(24), ClassRoom.data.ElementAt(13), 4);
            new MTC(Mapel.data.ElementAt(24), ClassRoom.data.ElementAt(14), 4);//bahasa indonesia
            new MTC(Mapel.data.ElementAt(24), ClassRoom.data.ElementAt(15), 4);
            new MTC(Mapel.data.ElementAt(24), ClassRoom.data.ElementAt(16), 4);
            new MTC(Mapel.data.ElementAt(24), ClassRoom.data.ElementAt(17), 4);

            new MTC(Mapel.data.ElementAt(25), ClassRoom.data.ElementAt(12), 2);
            new MTC(Mapel.data.ElementAt(25), ClassRoom.data.ElementAt(13), 2);
            new MTC(Mapel.data.ElementAt(25), ClassRoom.data.ElementAt(14), 2);//sejarah
            new MTC(Mapel.data.ElementAt(25), ClassRoom.data.ElementAt(15), 2);
            new MTC(Mapel.data.ElementAt(25), ClassRoom.data.ElementAt(16), 2);
            new MTC(Mapel.data.ElementAt(25), ClassRoom.data.ElementAt(17), 2);

            new MTC(Mapel.data.ElementAt(26), ClassRoom.data.ElementAt(10), 4);
            new MTC(Mapel.data.ElementAt(26), ClassRoom.data.ElementAt(11), 4);//sejarah minat
            new MTC(Mapel.data.ElementAt(26), ClassRoom.data.ElementAt(16), 4);
            new MTC(Mapel.data.ElementAt(26), ClassRoom.data.ElementAt(17), 4);

            new MTC(Mapel.data.ElementAt(27), ClassRoom.data.ElementAt(10), 4);
            new MTC(Mapel.data.ElementAt(27), ClassRoom.data.ElementAt(11), 4);//matematika wajib

            new MTC(Mapel.data.ElementAt(28), ClassRoom.data.ElementAt(6), 4);
            new MTC(Mapel.data.ElementAt(28), ClassRoom.data.ElementAt(7), 4);
            new MTC(Mapel.data.ElementAt(28), ClassRoom.data.ElementAt(8), 4);//matematika minat
            new MTC(Mapel.data.ElementAt(28), ClassRoom.data.ElementAt(9), 4);

            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(6), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(7), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(8), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(9), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(10), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(11), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(12), 2);//kesenian
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(13), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(14), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(15), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(16), 2);
            new MTC(Mapel.data.ElementAt(29), ClassRoom.data.ElementAt(17), 2);

            new MTC(Mapel.data.ElementAt(30), ClassRoom.data.ElementAt(6), 4);
            new MTC(Mapel.data.ElementAt(30), ClassRoom.data.ElementAt(7), 4);
            new MTC(Mapel.data.ElementAt(30), ClassRoom.data.ElementAt(8), 4);//bahasa indonesia
            new MTC(Mapel.data.ElementAt(30), ClassRoom.data.ElementAt(9), 4);
            new MTC(Mapel.data.ElementAt(30), ClassRoom.data.ElementAt(10), 4);
            new MTC(Mapel.data.ElementAt(30), ClassRoom.data.ElementAt(11), 4);

            new MTC(Mapel.data.ElementAt(31), ClassRoom.data.ElementAt(0), 2);
            new MTC(Mapel.data.ElementAt(31), ClassRoom.data.ElementAt(1), 2);
            new MTC(Mapel.data.ElementAt(31), ClassRoom.data.ElementAt(2), 2);//bahasa inggris
            new MTC(Mapel.data.ElementAt(31), ClassRoom.data.ElementAt(3), 2);
            new MTC(Mapel.data.ElementAt(31), ClassRoom.data.ElementAt(4), 2);
            new MTC(Mapel.data.ElementAt(31), ClassRoom.data.ElementAt(5), 2);

            new MTC(Mapel.data.ElementAt(32), ClassRoom.data.ElementAt(2), 3);
            new MTC(Mapel.data.ElementAt(32), ClassRoom.data.ElementAt(3), 3);
            new MTC(Mapel.data.ElementAt(32), ClassRoom.data.ElementAt(4), 3);//bahasa inggris minat
            new MTC(Mapel.data.ElementAt(32), ClassRoom.data.ElementAt(5), 3);

            new MTC(Mapel.data.ElementAt(33), ClassRoom.data.ElementAt(2), 3);
            new MTC(Mapel.data.ElementAt(33), ClassRoom.data.ElementAt(3), 3);//bahasa arab minat
            new MTC(Mapel.data.ElementAt(33), ClassRoom.data.ElementAt(15), 4);

            new MTC(Mapel.data.ElementAt(34), ClassRoom.data.ElementAt(0), 3);
            new MTC(Mapel.data.ElementAt(34), ClassRoom.data.ElementAt(1), 3);
            new MTC(Mapel.data.ElementAt(34), ClassRoom.data.ElementAt(2), 3);//pendidikan agama islam
            new MTC(Mapel.data.ElementAt(34), ClassRoom.data.ElementAt(3), 3);
            new MTC(Mapel.data.ElementAt(34), ClassRoom.data.ElementAt(4), 3);
            new MTC(Mapel.data.ElementAt(34), ClassRoom.data.ElementAt(5), 3);

            new MTC(Mapel.data.ElementAt(35), ClassRoom.data.ElementAt(6), 4);
            new MTC(Mapel.data.ElementAt(35), ClassRoom.data.ElementAt(7), 4);
            new MTC(Mapel.data.ElementAt(35), ClassRoom.data.ElementAt(12), 4);//kimia
            new MTC(Mapel.data.ElementAt(35), ClassRoom.data.ElementAt(13), 4);
            new MTC(Mapel.data.ElementAt(35), ClassRoom.data.ElementAt(14), 4);
            new MTC(Mapel.data.ElementAt(35), ClassRoom.data.ElementAt(15), 4);

            new MTC(Mapel.data.ElementAt(36), ClassRoom.data.ElementAt(0), 2);
            new MTC(Mapel.data.ElementAt(36), ClassRoom.data.ElementAt(1), 2);
            new MTC(Mapel.data.ElementAt(36), ClassRoom.data.ElementAt(2), 2);//sejarah
            new MTC(Mapel.data.ElementAt(36), ClassRoom.data.ElementAt(3), 2);

            new MTC(Mapel.data.ElementAt(37), ClassRoom.data.ElementAt(4), 3);//sejarah minat
            new MTC(Mapel.data.ElementAt(37), ClassRoom.data.ElementAt(5), 3);

            new MTC(Mapel.data.ElementAt(38), ClassRoom.data.ElementAt(6), 3);
            new MTC(Mapel.data.ElementAt(38), ClassRoom.data.ElementAt(7), 3);
            new MTC(Mapel.data.ElementAt(38), ClassRoom.data.ElementAt(8), 3);//p.agama dan budi pekerti
            new MTC(Mapel.data.ElementAt(38), ClassRoom.data.ElementAt(9), 3);
            new MTC(Mapel.data.ElementAt(38), ClassRoom.data.ElementAt(10), 3);
            new MTC(Mapel.data.ElementAt(38), ClassRoom.data.ElementAt(11), 3);

            new MTC(Mapel.data.ElementAt(40), ClassRoom.data.ElementAt(3), 3);
            new MTC(Mapel.data.ElementAt(40), ClassRoom.data.ElementAt(6), 4);
            new MTC(Mapel.data.ElementAt(40), ClassRoom.data.ElementAt(7), 4);//fisika
            new MTC(Mapel.data.ElementAt(40), ClassRoom.data.ElementAt(8), 4);
            new MTC(Mapel.data.ElementAt(40), ClassRoom.data.ElementAt(9), 4);

            new MTC(Mapel.data.ElementAt(41), ClassRoom.data.ElementAt(4), 3);
            new MTC(Mapel.data.ElementAt(41), ClassRoom.data.ElementAt(5), 3);
            new MTC(Mapel.data.ElementAt(41), ClassRoom.data.ElementAt(10), 4);//geografi
            new MTC(Mapel.data.ElementAt(41), ClassRoom.data.ElementAt(11), 4);
            new MTC(Mapel.data.ElementAt(41), ClassRoom.data.ElementAt(16), 4);
            new MTC(Mapel.data.ElementAt(41), ClassRoom.data.ElementAt(17), 4);

            new MTC(Mapel.data.ElementAt(42), ClassRoom.data.ElementAt(14), 4);//geografi minat

            new MTC(Mapel.data.ElementAt(43), ClassRoom.data.ElementAt(9), 3);
            new MTC(Mapel.data.ElementAt(43), ClassRoom.data.ElementAt(10), 3);
            new MTC(Mapel.data.ElementAt(43), ClassRoom.data.ElementAt(11), 3);//penjasorkes
            new MTC(Mapel.data.ElementAt(43), ClassRoom.data.ElementAt(12), 3);
            new MTC(Mapel.data.ElementAt(43), ClassRoom.data.ElementAt(13), 3);
            new MTC(Mapel.data.ElementAt(43), ClassRoom.data.ElementAt(14), 3);
            new MTC(Mapel.data.ElementAt(43), ClassRoom.data.ElementAt(15), 3);
            new MTC(Mapel.data.ElementAt(43), ClassRoom.data.ElementAt(16), 3);
            new MTC(Mapel.data.ElementAt(43), ClassRoom.data.ElementAt(17), 3);

            new MTC(Mapel.data.ElementAt(44), ClassRoom.data.ElementAt(16), 4);
            new MTC(Mapel.data.ElementAt(44), ClassRoom.data.ElementAt(17), 4);//matematika wajib


            new MTC(Mapel.data.ElementAt(45), ClassRoom.data.ElementAt(12), 4);
            new MTC(Mapel.data.ElementAt(45), ClassRoom.data.ElementAt(13), 4);
            new MTC(Mapel.data.ElementAt(45), ClassRoom.data.ElementAt(14), 4);//matematika minat
            new MTC(Mapel.data.ElementAt(45), ClassRoom.data.ElementAt(15), 4);

            new MTC(Mapel.data.ElementAt(46), ClassRoom.data.ElementAt(6), 4);
            new MTC(Mapel.data.ElementAt(46), ClassRoom.data.ElementAt(7), 4);
            new MTC(Mapel.data.ElementAt(46), ClassRoom.data.ElementAt(8), 4);//matematika wajib
            new MTC(Mapel.data.ElementAt(46), ClassRoom.data.ElementAt(9), 4);

            new MTC(Mapel.data.ElementAt(47), ClassRoom.data.ElementAt(0), 3);
            new MTC(Mapel.data.ElementAt(47), ClassRoom.data.ElementAt(1), 3);
            new MTC(Mapel.data.ElementAt(47), ClassRoom.data.ElementAt(2), 3);//matematika minat
            new MTC(Mapel.data.ElementAt(47), ClassRoom.data.ElementAt(3), 3);

            new MTC(Mapel.data.ElementAt(48), ClassRoom.data.ElementAt(0), 2);
            new MTC(Mapel.data.ElementAt(48), ClassRoom.data.ElementAt(1), 2);
            new MTC(Mapel.data.ElementAt(48), ClassRoom.data.ElementAt(2), 2);//pkn
            new MTC(Mapel.data.ElementAt(48), ClassRoom.data.ElementAt(3), 2);
            new MTC(Mapel.data.ElementAt(48), ClassRoom.data.ElementAt(4), 2);
            new MTC(Mapel.data.ElementAt(48), ClassRoom.data.ElementAt(5), 2);

            new MTC(Mapel.data.ElementAt(49), ClassRoom.data.ElementAt(6), 2);
            new MTC(Mapel.data.ElementAt(49), ClassRoom.data.ElementAt(7), 2);
            new MTC(Mapel.data.ElementAt(49), ClassRoom.data.ElementAt(8), 2);//sejarah wajib
            new MTC(Mapel.data.ElementAt(49), ClassRoom.data.ElementAt(9), 2);
            new MTC(Mapel.data.ElementAt(49), ClassRoom.data.ElementAt(10), 2);
            new MTC(Mapel.data.ElementAt(49), ClassRoom.data.ElementAt(11), 2);

            new MTC(Mapel.data.ElementAt(50), ClassRoom.data.ElementAt(0), 3);
            new MTC(Mapel.data.ElementAt(50), ClassRoom.data.ElementAt(1), 3);
            new MTC(Mapel.data.ElementAt(50), ClassRoom.data.ElementAt(2), 3);//penjasorkes
            new MTC(Mapel.data.ElementAt(50), ClassRoom.data.ElementAt(3), 3);
            new MTC(Mapel.data.ElementAt(50), ClassRoom.data.ElementAt(4), 3);
            new MTC(Mapel.data.ElementAt(50), ClassRoom.data.ElementAt(5), 3);
            new MTC(Mapel.data.ElementAt(50), ClassRoom.data.ElementAt(6), 3);
            new MTC(Mapel.data.ElementAt(50), ClassRoom.data.ElementAt(7), 3);
            new MTC(Mapel.data.ElementAt(50), ClassRoom.data.ElementAt(8), 3);

            new MTC(Mapel.data.ElementAt(51), ClassRoom.data.ElementAt(0), 2);
            new MTC(Mapel.data.ElementAt(51), ClassRoom.data.ElementAt(1), 2);
            new MTC(Mapel.data.ElementAt(51), ClassRoom.data.ElementAt(2), 2);//senibudaya
            new MTC(Mapel.data.ElementAt(51), ClassRoom.data.ElementAt(3), 2);
            new MTC(Mapel.data.ElementAt(51), ClassRoom.data.ElementAt(4), 2);
            new MTC(Mapel.data.ElementAt(51), ClassRoom.data.ElementAt(5), 2);

            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(6), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(7), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(8), 2);//bahasa daerah
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(9), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(10), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(11), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(12), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(13), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(14), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(15), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(16), 2);
            new MTC(Mapel.data.ElementAt(52), ClassRoom.data.ElementAt(17), 2);

            new MTC(Mapel.data.ElementAt(53), ClassRoom.data.ElementAt(0), 1);
            new MTC(Mapel.data.ElementAt(53), ClassRoom.data.ElementAt(1), 1);
            new MTC(Mapel.data.ElementAt(53), ClassRoom.data.ElementAt(2), 1);//bk
            new MTC(Mapel.data.ElementAt(53), ClassRoom.data.ElementAt(3), 1);
            new MTC(Mapel.data.ElementAt(53), ClassRoom.data.ElementAt(4), 1);
            new MTC(Mapel.data.ElementAt(53), ClassRoom.data.ElementAt(5), 1);

            new MTC(Mapel.data.ElementAt(55), ClassRoom.data.ElementAt(4), 4);
            new MTC(Mapel.data.ElementAt(55), ClassRoom.data.ElementAt(5), 4);//bahasa indonesia

            new MTC(Mapel.data.ElementAt(57), ClassRoom.data.ElementAt(0), 3);
            new MTC(Mapel.data.ElementAt(57), ClassRoom.data.ElementAt(1), 3);
            new MTC(Mapel.data.ElementAt(57), ClassRoom.data.ElementAt(7), 4);//geografi minat

            new MTC(Mapel.data.ElementAt(58), ClassRoom.data.ElementAt(4), 3);
            new MTC(Mapel.data.ElementAt(58), ClassRoom.data.ElementAt(5), 3);//sosiologi dan antropologi

            new MTC(Mapel.data.ElementAt(59), ClassRoom.data.ElementAt(4), 2);
            new MTC(Mapel.data.ElementAt(59), ClassRoom.data.ElementAt(5), 2);//sejarah wajib

            /*
            for(int i = 0; i < ClassRoom.data.Count; i++)
            {
                System.Windows.Forms.MessageBox.Show(gethardmapel(ClassRoom.data.ElementAt(i).name).ToString());
            }
            */
        }
    }
}
