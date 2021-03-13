using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprioriGA
{
    public class Waktu
    {
        public static LinkedList<Waktu> Data;
        //bikin object baru isinya hour day time
        //jam ke berapa
        //1-n
        public int hour;
        //hari ke
        //1-5
        public int day;
        //waktu mulai da berakhir mapelnya
        public String starttime;
        public String endtime;
        public Waktu(int d, int h, String s, String e)
        {
            if (Data == null)
            {
                Data = new LinkedList<Waktu>();
            }
            this.hour = h;
            this.day = d;
            this.starttime = s;
            this.endtime = e;
            Data.AddLast(this);
        }

        public static void initiate()
        {
            for (int i = 1; i < 5; i++)
            {
                new Waktu(i, 1, "07.10", "07.50");
                new Waktu(i, 2, "07.50", "08.30");
                new Waktu(i, 3, "08.30", "09.10");
                new Waktu(i, 4, "09.25", "10.05");
                new Waktu(i, 5, "10.05", "10.45");
                new Waktu(i, 6, "10.45", "11.25");
                new Waktu(i, 7, "11.25", "12.05");
                new Waktu(i, 8, "12.35", "13.15");
                new Waktu(i, 9, "13.15", "13.55");
                new Waktu(i, 10, "13.55", "14.35");
                new Waktu(i, 11, "14.35", "15.15");
            }
            new Waktu(5, 1, "07.25", "08.05");
            new Waktu(5, 2, "08.05", "08.45");
            new Waktu(5, 3, "08.45", "09.25");
            new Waktu(5, 4, "09.40", "10.20");
            new Waktu(5, 5, "10.20", "11.00");
            new Waktu(5, 7, "13.00", "13.40");
            new Waktu(5, 8, "13.40", "14.20");

        }

        public static Waktu[] getDayWaktu(int when)
        {
            List<Waktu> now = new List<Waktu>();
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).day == when)
                {
                    now.Add(Data.ElementAt(i));
                }
            }
            return now.ToArray();
        }
    }
}
