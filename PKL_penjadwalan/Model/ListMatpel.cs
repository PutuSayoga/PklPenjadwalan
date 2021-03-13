using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKL_penjadwalan.Model
{
    public class ListMatpel : List<M_Matpel>
    {
        private static ListMatpel listMatpel = new ListMatpel();

        private ListMatpel() { }

        public static void addToList(M_Matpel newData)
        {
            if(newData != null)
            {
                if (!listMatpel.Contains(newData))
                {
                    listMatpel.Add(newData);
                }
            }
        }

        public static ListMatpel getList()
        {
            return listMatpel;
        }

        public static M_Matpel getMatpelByKode(string kode, string naman)
        {
            M_Matpel matpelSearched = listMatpel.Find(matpel => matpel.kodeMatpel == kode && matpel.namaMatpel == naman);
            if(listMatpel.Contains(matpelSearched))
                return matpelSearched;
            else
                return null;
        }

        public static void editMatpelByKode(string oldKode,string nama, M_Matpel newData)
        {
            int index = listMatpel.FindIndex(matpel => matpel.kodeMatpel == oldKode && matpel.namaMatpel == nama);
            ListTugas.editMatpelInTugas(oldKode, newData);
            listMatpel[index] = newData;
        }

        public static void deleteMatpelByKode(string kode, string nama)
        {
            M_Matpel deletedData = listMatpel.Find(matpel => matpel.kodeMatpel == kode && matpel.namaMatpel == nama);
            ListTugas.deleteMatpelInTugas(kode);
            listMatpel.Remove(deletedData);
        }

        public static void clearList()
        {
            listMatpel.Clear();
        }
    }
}
