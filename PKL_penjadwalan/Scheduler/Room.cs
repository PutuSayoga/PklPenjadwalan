using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AprioriGA
{
    public class Room
    {
        public static LinkedList<Room> Data;
        public ClassRoom roomclass;
        public Mapel mapel;
        public Waktu wkt;

        public static String ruang()
        {
            String z = "";
            for (int i=0;i<Data.Count;i++)
            {
                if(Data.ElementAt(i).wkt.day==5)
                z += (Data.ElementAt(i).wkt.day +" "+ Data.ElementAt(i).wkt.hour +" "+ Data.ElementAt(i).roomclass.name+" , ");
            }
            return z;
        }

        public Room(ClassRoom kls, Mapel mpl, Waktu waktu)
        {
            if (Data == null)
            {
                Data = new LinkedList<Room>();
            }
            roomclass = kls;
            mapel = mpl;
            wkt = waktu;
            Data.AddLast(this);
        }

        public static Room[] GetAllRoom()
        {
            return Data.ToArray();
        }

        public static Room[] GetClassRoom(String x)
        {
            LinkedList<Room> ro = new LinkedList<Room>();
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).roomclass.name == x)
                {
                    ro.AddLast(Data.ElementAt(i));
                }
            }
            return ro.ToArray();
        }

        public static Room[] GetDayClassRoom(String x,int da)
        {
            List<Room> dat = new List<Room>();
            for (int i = 0; i < Data.Count; i++)
            {
                if ((Room.Data.ElementAt(i).roomclass.name==x)
                    &&(Room.Data.ElementAt(i).wkt.day==da))
                {
                    dat.Add(Room.Data.ElementAt(i));
                }
            }
            return dat.ToArray();
        }

        public static Room[] GetDayRoom(int x)
        {
            LinkedList<Room> ro = new LinkedList<Room>();
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data.ElementAt(i).wkt.day == x)
                {
                    ro.AddLast(Data.ElementAt(i));
                }
            }
            return ro.ToArray();
        }

        public static void reorder()
        {
            List<Room> peng = new List<Room>();
            for (int i = 0; i < ClassRoom.data.Count; i++)
            {
                peng.AddRange(GetClassRoom(ClassRoom.data.ElementAt(i).name));
            }
            Data = new LinkedList<Room>(peng.AsEnumerable());
        }

        public static void instalkelas()
        {
            int[,] a = new int[,] { { 10, 10, 10, 10, 7 }, { 11, 10, 11, 10, 7 }, { 10, 10, 10, 10, 7 } };
            for (int x = 1; x < 6; x++)
            {
                for (int kls = 0; kls < ClassRoom.data.Count; kls++)
                {
                    Waktu[] y = Waktu.getDayWaktu(x);
                    for (int wk = 0; wk < a[ClassRoom.data.ElementAt(kls).generation - 10, x - 1]; wk++)
                    {
                        if (!((((ClassRoom.data.ElementAt(kls).generation == 10) && ((y[wk].hour == 4) || (y[wk].hour == 5))) ||
                          ((ClassRoom.data.ElementAt(kls).generation == 11) && ((y[wk].hour == 7) || (y[wk].hour == 8)))) && (x == 5)))
                        {
                            new Room(ClassRoom.data.ElementAt(kls), null, y[wk]);
                        }
                    }
                }
            }
            reorder();
        }

        // hari -> kelas
        public static void initiate()
        {
            int[,] a = new int[,] { { 10, 10, 10, 10, 7 }, { 11, 10, 11, 10, 7 }, { 10, 10, 10, 10, 7 } };
            for (int x = 1; x < 6; x++)
            {
                for (int kls = 0; kls < ClassRoom.data.Count; kls++)
                {
                    Waktu[] y = Waktu.getDayWaktu(x);
                    for (int wk = 0; wk < a[ClassRoom.data.ElementAt(kls).generation-10,x-1]; wk++)
                    {
                        if (!((((ClassRoom.data.ElementAt(kls).generation==10)&&((y[wk].hour==4)|| (y[wk].hour == 5)))||
                          ((ClassRoom.data.ElementAt(kls).generation == 11) && ((y[wk].hour == 7) || (y[wk].hour == 8))))&&(x==5)))
                        {
                                new Room(ClassRoom.data.ElementAt(kls), null, y[wk]);
                        }
                    }
                }
            }
            reorder();
        }

    }
}
