using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKL_penjadwalan.Model;

namespace PKL_penjadwalan.Model
{
    public class ListGuru : List<M_Guru>
    {
        private static ListGuru listGuru = new ListGuru();

        private ListGuru() { }

        public static void addToList(M_Guru newData)
        {
            if (newData != null)
            {
                if (!listGuru.Contains(newData))
                {
                    listGuru.Add(newData);
                }
            }
        }

        public static ListGuru getList()
        {
            return listGuru;
        }

        public static M_Guru getGuruByKode(string kode, string nama)
        {
            M_Guru guruSearched = listGuru.Find(guru => guru.kodeGuru == kode && guru.namaGuru == nama);
            if (listGuru.Contains(guruSearched))
                return guruSearched;
            else
                return null;
        }

        public static void editGuruByKode(string oldKode, string nama, M_Guru newData)
        {
            int index = listGuru.FindIndex(guru => guru.kodeGuru == oldKode && guru.namaGuru == nama);
            ListTugas.editGuruInTugas(oldKode, newData);
            listGuru[index] = newData;
        }

        public static void deleteGuruByKode(string kode, string nama)
        {
            M_Guru deletedData = listGuru.Find(guru => guru.kodeGuru == kode && guru.namaGuru == nama);
            ListTugas.deleteGuruInTugas(kode);
            listGuru.Remove(deletedData);
        }

        public static void clearList()
        {
            listGuru.Clear();
        }
    }
}
