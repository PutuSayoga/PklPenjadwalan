using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKL_penjadwalan.Model
{
    public class ListKelas : List<M_Kelas>
    {
        private static ListKelas listKelas = new ListKelas();

        private ListKelas() { }

        public static void addToList(M_Kelas newData)
        {
            if (newData != null)
            {
                if (!listKelas.Contains(newData))
                {
                    listKelas.Add(newData);
                }
            }
        }

        public static ListKelas getList()
        {
            return listKelas;
        }

        public static M_Kelas getKelasByNama(string nama)
        {
            M_Kelas kelasSearched = listKelas.Find(kelas => kelas.namaKelas == nama);
            if(listKelas.Contains(kelasSearched))
                return kelasSearched;
            else
                return null;
        }

        public static void editKelasByNama(string nama, M_Kelas newData)
        {
            int index = listKelas.FindIndex(kelas => kelas.namaKelas == nama);
            ListTugas.editKelasInTugas(nama, newData.namaKelas);
            listKelas[index] = newData;
        }

        public static void deleteKelasByNama(string nama)
        {
            M_Kelas deletedData = listKelas.Find(kelas => kelas.namaKelas == nama);
            ListTugas.deleteKelasInTugas(nama);
            listKelas.Remove(deletedData);
        }

        public static void clearList()
        {
            listKelas.Clear();
        }
    }
}
