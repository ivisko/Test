using System.Collections.Generic;

namespace EvidenciaHudobnychAlbumovIvanRajnic //
{
    public class SortByDatumZalozenia : IComparer<Skupina>
    {
        public int Compare(Skupina x, Skupina y)
        {
            return x.DatumZalozenia.CompareTo(y.DatumZalozenia);
        }
    }
}
