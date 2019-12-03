using System;
using System.Collections.Generic;

namespace EvidenciaHudobnychAlbumovIvanRajnic  //
{
    public class Album : IComparable 
    {
        public string Nazov { get; set; }
        public int Cislo { get; set; }
        public DateTime Datum { get; set; }
        public string Zaner { get; set; }
        public string Popis { get; set; }

        public static List<Album> zoznam = new List<Album>();

        public Album(string nazov, int cislo, DateTime datum, string zaner, string popis)
        {
            Nazov = nazov;
            Cislo = cislo;
            Datum = datum;
            Zaner = zaner;
            Popis = popis;
        }
        public void PridajDoZoznamu()
        {
            zoznam.Add(this);
        }
        public void UpravDoZoznamu(int index)
        {
            zoznam[index].Cislo = this.Cislo;
            zoznam[index].Nazov = this.Nazov;
            zoznam[index].Datum = this.Datum;
            zoznam[index].Zaner = this.Zaner;
            zoznam[index].Popis = this.Popis;
        }
        public void ZmazAlbum(int index)
        {
            zoznam.RemoveAt(index);
        }
        public int CompareTo(object obj)
        {
            if (obj is Album)
            {
                Album album = obj as Album;
                int res = this.Nazov.CompareTo(album.Nazov);
                if (res != 0) return res;
                res = this.Cislo.CompareTo(album.Cislo);
                return res;
            }
            return 0;
        }
    }
}
