using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKL_penjadwalan.Model
{
    public class ListTugas : List<M_Tugas>
    {
        private static ListTugas listTugas = new ListTugas();

        private ListTugas() { }

        public static void addToList(M_Tugas newData)
        {
            if (newData != null)
            {
                if (!listTugas.Contains(newData))
                {
                    listTugas.Add(newData);
                }
            }
        }

        public static ListTugas getList()
        {
            return listTugas;
        }

        public static M_Tugas getTugasByKode(string kode, int jam)
        {
            M_Tugas tugasSearched = listTugas.Find(tugas => tugas.kodeTugas == kode && tugas.jatahJam.Equals(jam));
            if(listTugas.Contains(tugasSearched))
                return tugasSearched;
            else
                return null;
        }

        public static void editTugasByKode(string kode, int jam, M_Tugas newTugas)
        {
            int index = listTugas.FindIndex(tugas => tugas.kodeTugas == kode && tugas.jatahJam.Equals(jam));
            listTugas[index] = newTugas;
        }

        public static void editGuruInTugas(string oldKode, M_Guru newData)
        {
            if (!listTugas.Count.Equals(0))
            {
                for(int i = 0; i < listTugas.Count; i++)
                {
                    if (listTugas[i].guru.kodeGuru == oldKode)
                    {
                        listTugas[i].guru = newData;
                        listTugas[i].kodeTugas = $"{listTugas[i].guru.kodeGuru} {listTugas[i].matpel.kodeMatpel}";
                    }
                }
            }
        }

        public static void editMatpelInTugas(string oldKode, M_Matpel newData)
        {
            if (!listTugas.Count.Equals(0))
            {
                for (int i = 0; i < listTugas.Count; i++)
                {
                    if (listTugas[i].matpel.kodeMatpel == oldKode)
                    {
                        listTugas[i].matpel = newData;
                        listTugas[i].kodeTugas = $"{listTugas[i].guru.kodeGuru} {listTugas[i].matpel.kodeMatpel}";
                    }
                }
            }
        }

        public static void editKelasInTugas(string oldKelas, string newKelas)
        {
            if (!listTugas.Count.Equals(0))
            {
                for (int i = 0; i < listTugas.Count; i++)
                {
                    for(int j = 0; j < listTugas[i].jatahKelas.Count; j++)
                    {
                        if (listTugas[i].jatahKelas[j] == oldKelas)
                        {
                            listTugas[i].jatahKelas[j] = newKelas;
                        }
                    }
                }
            }

        }

        public static void deleteTugasByKode(string kode, int jam)
        {
            listTugas.RemoveAll(tugas => tugas.kodeTugas == kode && tugas.jatahJam.Equals(jam));
        }

        public static void deleteGuruInTugas(string deletedKodeGuru)
        {
            if (!listTugas.Count.Equals(0))
            {
                for (int i = 0; i < listTugas.Count; i++)
                {
                    if (listTugas[i].guru.kodeGuru == deletedKodeGuru)
                    {
                        deleteTugasByKode(listTugas[i].kodeTugas, listTugas[i].jatahJam);
                    }
                }
            }
        }

        public static void deleteMatpelInTugas(string deletedKodeMatpel)
        {
            if (!listTugas.Count.Equals(0))
            {
                for (int i = 0; i < listTugas.Count; i++)
                {
                    if (listTugas[i].matpel.kodeMatpel == deletedKodeMatpel)
                    {
                        deleteTugasByKode(listTugas[i].kodeTugas, listTugas[i].jatahJam);
                    }
                }
            }
        }

        public static void deleteKelasInTugas(string deletedKelas)
        {
            if (!listTugas.Count.Equals(0))
            {
                for (int i = 0; i < listTugas.Count; i++)
                {
                    listTugas[i].jatahKelas.Remove(deletedKelas);
                    for (int j = 0; j < listTugas[i].jatahKelas.Count; j++)
                    {
                        listTugas[i].jatahKelas.Remove(deletedKelas);
                    }
                }
            }
        }

        public static void clearList()
        {
            listTugas.Clear();
        }
    }

}
