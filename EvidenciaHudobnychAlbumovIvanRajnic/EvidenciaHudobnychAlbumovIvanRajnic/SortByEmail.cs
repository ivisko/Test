using System.Collections.Generic;

namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    public class SortByEmail : IComparer<Skupina> //
    {
        public int Compare(Skupina x, Skupina y)
        {
            return x.Email.CompareTo(y.Email);
        }
    }
}
