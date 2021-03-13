using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprioriGA
{
    public class Chromosome1
    {
        public int[] gene;
        public double fitness;
        Room[] ros;
        static Random rnd = new Random();
        public String[] dua;
        public int[] getGene()
        {
            return gene;
        }
        public Chromosome1(int[] gen)
        {
            gene = gen;
            dua = MTC.dua();
            //System.Windows.Forms.MessageBox.Show(gene.Length.ToString());
            fitness = calcfit12();
        }

        public double calcfit12()
        {
            double a = 0;
            ros = ruang();
            List<String> seminggu = new List<string>();
            for (int i = 0; i < ros.Length; i++)
            {
                int counter1 = 0;
                int counter2 = 0;
                int jatah = MTC.getJatahMapel(ros[i].mapel.IdTeacher, ros[i].roomclass.name);
                List<String> sehari = new List<string>();
                for (int j = 0; j < ros.Length; j++)
                {
                    //guru tidak mengajar 2 kelas secara bersamaan
                    if ((ros[i].wkt.day == ros[j].wkt.day) && (ros[i].wkt.hour == ros[j].wkt.hour) &&
                        (ros[i].roomclass.name != ros[j].roomclass.name)
                        && (ros[i].mapel.IdTeacher.Split(' ')[0] == ros[j].mapel.IdTeacher.Split(' ')[0]))
                    {
                        a += 1;
                    }
                    //tidak ada guru mengajar 2 mapel dikelas yang sama
                    if ((ros[i].wkt.day == ros[j].wkt.day) && (i != j) && (ros[i].roomclass.name == ros[j].roomclass.name)
                        && (ros[i].mapel.IdTeacher.Split(' ')[0] == ros[j].mapel.IdTeacher.Split(' ')[0])
                        && (ros[i].mapel.IdTeacher != ros[j].mapel.IdTeacher))
                    {
                        a += 1;
                    }
                    //hitung jatah per hari
                    if ((ros[i].roomclass.name == ros[j].roomclass.name) && (ros[i].wkt.day == ros[j].wkt.day)
                        && (ros[i].mapel.IdTeacher == ros[j].mapel.IdTeacher))
                    {
                        counter1 += 1;
                    }
                    //hitung jatah per minggu
                    if ((ros[i].roomclass.name == ros[j].roomclass.name) && (ros[i].mapel.IdTeacher == ros[j].mapel.IdTeacher))
                    {
                        counter2 += 1;
                    }
                    if ((ros[i].wkt.day == ros[j].wkt.day) && (ros[i].roomclass.name == ros[j].roomclass.name)
                        && (ros[i].mapel.Dasar == ros[j].mapel.Dasar) && (ros[i].mapel.IdTeacher != ros[j].mapel.IdTeacher))
                    {
                        a += 1;
                    }
                }
                int maks;
                if (MTC.Limit3.Contains(ros[i].mapel.IdTeacher))
                {
                    if (jatah != 3)
                    {
                        a += 0.5f;
                    }
                }
                else
                {
                    if (jatah < 2)
                    {
                        maks = jatah;
                    }
                    else
                    {
                        maks = 2;
                    }
                    if (!sehari.Contains(ros[i].mapel.IdTeacher))
                    {
                        //dicek jika diatas dan dibawah 2
                        if (counter1 > maks)
                        {
                            a += (counter1 - maks);
                        }
                        else if (counter1 < maks)
                        {
                            a += (maks - counter1);
                        }
                        sehari.Add(ros[i].mapel.IdTeacher);
                    }

                    if (!seminggu.Contains(ros[i].mapel.IdTeacher))
                    {
                        if (counter2 > jatah)
                        {
                            a += (counter2 - jatah);
                        }
                        seminggu.Add(ros[i].mapel.IdTeacher);
                    }
                }

            }


            return 100 / (1 + a);
        }


        public Room[] ruang()
        {
            List<Room> ro = new List<Room>();
            // System.Windows.Forms.MessageBox.Show(gene.Length.ToString());
            for (int i = 0; i < gene.Length; i++)
            {
                ro.AddRange(allCSPDB.hasil.ElementAt(i).Ruang(gene[i]).AsEnumerable());
            }
            //System.Windows.Forms.MessageBox.Show(ro.Count.ToString());
            return ro.ToArray();
        }

        public static Chromosome1 generateRandom()
        {
            int[] gen = new int[allCSPDB.hasil.Count];
            for (int i = 0; i < gen.Length; i++)
            {
                gen[i] = rnd.Next(allCSPDB.hasil.ElementAt(i).allsol.Count);
            }
            return new Chromosome1(gen);
        }

        public Chromosome1 Mutate()
        {
            int[] gen = getGene();
            int pos = rnd.Next(gen.Length);
            int chggene = rnd.Next(allCSPDB.hasil.ElementAt(pos).kemungkinan().Count);

            gen[pos] = chggene;
            return new Chromosome1(gen);
        }

        public Chromosome1[] mate(Chromosome1 mate)
        {
            Chromosome1[] child = new Chromosome1[2];
            int matepos = rnd.Next(gene.Length);
            List<int> tempo = new List<int>();
            tempo.AddRange(getGene().ToList().GetRange(0, matepos));
            tempo.AddRange(mate.getGene().ToList().GetRange(matepos, gene.Length - matepos));
            child[0] = new Chromosome1(tempo.ToArray());
            tempo = new List<int>();

            tempo.AddRange(mate.getGene().ToList().GetRange(0, matepos));
            tempo.AddRange(getGene().ToList().GetRange(matepos, gene.Length - matepos));

            child[1] = new Chromosome1(tempo.ToArray());
            return child;
        }

    }
}
