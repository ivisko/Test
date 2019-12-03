using System.Collections.Generic;

namespace EvidenciaHudobnychAlbumovIvanRajnic //
{
    class SortByDatum : IComparer<Album>
    {
        public int Compare(Album x, Album y)
        {
            return x.Datum.CompareTo(y.Datum);
        }
    }
}
