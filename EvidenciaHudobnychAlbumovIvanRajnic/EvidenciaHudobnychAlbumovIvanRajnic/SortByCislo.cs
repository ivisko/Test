using System.Collections.Generic;

namespace EvidenciaHudobnychAlbumovIvanRajnic //
{
    class SortByCislo : IComparer<Album>
    {
        public int Compare(Album x, Album y)
        {
            return x.Cislo.CompareTo(y.Cislo);
        }
    }
}
