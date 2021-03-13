using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKL_penjadwalan.Model;

namespace AprioriGA
{
    public class ClassRoom
    {
        public static LinkedList<ClassRoom> data;
        public String name;
        public int floor;
        public String type;
        public int generation;

        public ClassRoom(String name, int flo, int gen,String typ)
        {
            if (data == null)
            {
                data = new LinkedList<ClassRoom>();
            }
            this.name = name;
            this.floor = flo;
            this.type = typ;
            this.generation = gen;
            data.AddLast(this);
        }

        public static ClassRoom getbyId(String nam)
        {
            for(int i = 0; i < data.Count; i++)
            {
                if (data.ElementAt(i).name == nam)
                {
                    return data.ElementAt(i);
                }
            }
            return null;
        }

        //tambahan
        public static void instalKelas(List<M_Kelas> listKelas)
        {
            foreach(M_Kelas kelas in listKelas)
            {
                new ClassRoom(kelas.namaKelas, 0, int.Parse(kelas.angkatan), kelas.jenis);
            }
        }

        public static void initiate()
        {
            new ClassRoom("X MIA1", 3, 10, "MIA");
            new ClassRoom("X MIA2", 3, 10, "MIA");
            new ClassRoom("X MIA3", 3, 10, "MIA");
            new ClassRoom("X MIA4", 3, 10, "MIA");
            new ClassRoom("X IIS1", 3, 10, "IIS");
            new ClassRoom("X IIS2", 3, 10, "IIS");
            new ClassRoom("XI MIA1", 2, 11, "MIA");
            new ClassRoom("XI MIA2", 2, 11, "MIA");
            new ClassRoom("XI MIA3", 2, 11, "MIA");
            new ClassRoom("XI MIA4", 2, 11, "MIA");
            new ClassRoom("XI IIS1", 2, 11, "IIS");
            new ClassRoom("XI IIS2", 2, 11, "IIS");
            new ClassRoom("XII MIA1", 3, 12, "MIA");
            new ClassRoom("XII MIA2", 3, 12, "MIA");
            new ClassRoom("XII MIA3", 2, 12, "MIA");
            new ClassRoom("XII MIA4", 2, 12, "MIA");
            new ClassRoom("XII IIS1", 2, 12, "IIS");
            new ClassRoom("XII IIS2", 2, 12, "IIS");

        }

    }
}
