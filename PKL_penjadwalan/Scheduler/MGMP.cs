using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKL_penjadwalan.Model;

namespace AprioriGA
{
    public class MGMP
    {
        public static LinkedList<MGMP> Data;
        String idteacher;
        //1-5
        int day;
        public MGMP(String s, int d)
        {
            if (Data == null)
            {
                Data = new LinkedList<MGMP>();
            }
            this.idteacher = s;
            this.day = d;
            Data.AddLast(this);
        }
        
        public static int getMGMPbyTeacher(String k)
        {
            for(int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).idteacher == k)
                    return Data.ElementAt(i).day;
            }
            return 0;
        }
        public static String[] getDayMGMP(int da)
        {
            List<String> baru = new List<String>();
            for(int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).day!=da)
                {
                    baru.Add(Data.ElementAt(i).idteacher);
                }
            }
            return baru.ToArray();
        }

        //tambahan
        public static void instalMGMP(List<M_Guru> listGuru)
        {
            foreach(M_Guru guru in listGuru)
            {
                new MGMP(guru.kodeGuru, guru.mgmp);
            }
        }

        public static void initiate()
        {
            new MGMP("2", 4);
            new MGMP("3", 1);
            new MGMP("4", 2);
            new MGMP("5", 2);
            new MGMP("6", 1);
            new MGMP("7", 4);
            new MGMP("8", 4);
            new MGMP("9", 1);
            new MGMP("10", 1);
            new MGMP("11", 2);
            new MGMP("12", 6);
            new MGMP("13", 6);
            new MGMP("14", 6);
            new MGMP("15", 6);
            new MGMP("16", 6);
            new MGMP("17", 3);
            new MGMP("18", 4);
            new MGMP("19", 2);
            new MGMP("20", 3);
            new MGMP("21", 6);
            new MGMP("22", 4);
            new MGMP("23", 2);
            new MGMP("24", 1);
            new MGMP("25", 6);
            new MGMP("26", 6);
            new MGMP("27", 4);
            new MGMP("28", 3);
            new MGMP("29", 3);
            new MGMP("30", 3);
            new MGMP("31", 2);
            new MGMP("32", 6);
            new MGMP("33", 6);
            new MGMP("34", 1);
            new MGMP("38", 4);
            new MGMP("39", 3);
            new MGMP("40", 1);
            new MGMP("41", 3);
            new MGMP("42", 3);
            new MGMP("43", 2);
            new MGMP("45", 6);
        }
    }
}
