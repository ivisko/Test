using System;
using System.Collections.Generic;

namespace EvidenciaHudobnychAlbumovIvanRajnic //
{
    public class Skupina : IComparable
    {
        public string Nazov { get; set; }
        public string Agent { get; set; }
        public DateTime DatumZalozenia { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Info { get; set; }
        public List<Album> nahrateAlbumy = new List<Album>();
        public static List<Skupina> zoznam = new List<Skupina>();
        public Skupina(string nazov, string agent, DateTime datumZalozenia, string email, string adresa, string info)
        {
            Nazov = nazov;
            Agent = agent;
            DatumZalozenia = datumZalozenia;
            Email = email;
            Adresa = adresa;
            Info = info;
        }
        public int CompareTo(object obj)
        {
            if (obj is Skupina)
            {
                Skupina skupina = obj as Skupina;
                int res = this.Nazov.CompareTo(skupina.Nazov);
                return res;
                
            }
            return 0;
        }
        public void PridajDoZoznamu()
        {
            zoznam.Add(this);
        }
        public void UpravDoZoznamu(int index)
        {
            zoznam[index].Nazov = this.Nazov;
            zoznam[index].Agent = this.Agent;
            zoznam[index].DatumZalozenia = this.DatumZalozenia;
            zoznam[index].Email = this.Email;
            zoznam[index].Adresa = this.Adresa;
            zoznam[index].Info = this.Info;
        }
        public void ZmazKapelu(int index)
        {
            zoznam.RemoveAt(index);
        }
    }
}
