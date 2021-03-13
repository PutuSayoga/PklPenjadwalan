using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AprioriGA
{
    public class CSP2
    {
        public Room[] ansclas;
        public int[] solution_now;
        public LinkedList<String>[] posible;
        public String[] Sambungan;
        public List<String[]> allsol;
        public int start, end, day;
        public String kelas;

        public int getCountSolution()
        {
            return allsol.Count;
        }

        public String[] hasil(int idx)
        {
            String[] hasil = new string[allsol.ElementAt(idx).Length];

            for (int i = 0; i < hasil.Length; i++)
            {
                hasil[i] = allsol.ElementAt(idx)[i];
            }
            //System.Windows.Forms.MessageBox.Show(hasil[0] + " " + hasil[1] + " " + hasil[2]);

            return hasil;
        }

        public CSP2(String kls, int da, int st, int en)
        {
            day = da;
            start = st;
            end = en;
            kelas = kls;

            ansclas = Room.GetDayClassRoom(kls, da);
            posible = new LinkedList<String>[en - st + 1];
            solution_now = new int[en - st + 1];
            allsol = new List<String[]>();
            Sambungan = MTC.dua();
            for (int i = st; i <= en; i++)
            {
                posible[i - st] = new LinkedList<string>(MTC.getTimeMapel(da, kls, i));
            }
            backtrack(0);
        }

        public Room[] Ruang(int idx)
        {
            List<Room> hasil = new List<Room>();
            try
            {
                for (int i = 0; i < ansclas.Length; i++)
                {
                    Room smnt = this.ansclas[i];
                    if ((ansclas[i].wkt.hour >= start) && (ansclas[i].wkt.hour <= end))
                    {
                        smnt.mapel = Mapel.getMapelbyID(allsol.ElementAt(idx)[smnt.wkt.hour - start]);
                        hasil.Add(smnt);
                    }
                }
            }
            catch{ }
            return hasil.ToArray();
        }

        //perbaiki lagi
        public Room[] ruangan(int idx)
        {
            List<Room> xyz = new List<Room>();
            for (int i = 0; i < allsol[idx].Length; i++)
            {
                Room[] x = Room.GetDayClassRoom(kelas, day);
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[j].wkt.hour == start + i)
                    {
                        x[j].mapel = Mapel.getMapelbyID(allsol.ElementAt(idx)[i]);
                        xyz.Add(x[j]);
                    }
                }
            }
            return xyz.ToArray();
        }

        public int[] mungkin()
        {
            List<int> hasil = new List<int>();
            for (int i = start; i <= end; i++)
            {
                hasil.Add(i);
            }
            return hasil.ToArray();
        }

        public String[] kode(int idx)
        {
            return kemungkinan().ElementAt(idx);
        }

        public List<String[]> kemungkinan()
        {
            List<String[]> total = new List<string[]>();
            for (int i = 0; i < allsol.Count; i++)
            {
                String[] kode = new String[allsol.ElementAt(i).Length];
                for (int j = 0; j < allsol.ElementAt(i).Length; j++)
                {
                    kode[j] = allsol.ElementAt(i)[j];
                }
                total.Add(kode);
            }
            return total;
        }

        public bool constraintnempel()
        {
            for (int i = 0; i < posible.Length; i++)
            {
                int total = 0;
                for (int j = 0; j < posible.Length; j++)
                {
                    if ((posible[i].ElementAt(solution_now[i]) == posible[j].ElementAt(solution_now[j])))
                    {
                        total += 1;
                    }
                    if ((posible[i].ElementAt(solution_now[i]) == posible[j].ElementAt(solution_now[j]))
                        && (Math.Abs(j - i) > 1) && (!MTC.Limit3.Contains(posible[i].ElementAt(solution_now[i]))))
                    {
                        return false;
                    }
                }
                if (total > MTC.getJatahMapel(posible[i].ElementAt(solution_now[i]), kelas))
                {
                    return false;
                }

                if ((i > 0) && (i < (posible.Length - 1)) && (total == 1)
                    && Sambungan.Contains(posible[i].ElementAt(solution_now[i])))
                {
                    return false;
                }

                if (i == 0)
                    if ((start == 1) && (Sambungan.Contains(posible[0].ElementAt(solution_now[0]))) && (total == 1))
                    {
                        return false;
                    }

                if (i == posible.Length)
                    if ((end == Room.GetDayClassRoom(kelas, day).Length) && (total == 1)
                        && (Sambungan.Contains(posible[posible.Length - 1].ElementAt(solution_now[posible.Length - 1]))))
                    {
                        return false;
                    }
            }
            return true;
        }

        public void backtrack(int pos)
        {
            if (pos < solution_now.Length)
            {
                for (int i = 0; i < posible[pos].Count; i++)
                {
                    solution_now[pos] = i;
                    backtrack(pos + 1);
                }
            }
            if ((pos == solution_now.Length) && constraintnempel())
            {
                int[] hasil = solution_now.ToArray();
                String[] has = new String[hasil.Length];
                for (int i = 0; i < hasil.Length; i++)
                {
                    has[i] = posible[i].ElementAt(hasil[i]);
                }
                allsol.Add(has);
            }
        }


        public int posiblelength()
        {
            int a = 0;
            for (int i = 0; i < posible.Length; i++)
            {
                a += posible[i].Count;
            }
            return a;
        }

        public String allLength()
        {
            String a = "";
            for (int i = 0; i < posible.Length; i++)
            {
                a = a + posible[i].Count.ToString() + ", ";
            }
            return a;
        }
    }
}