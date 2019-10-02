package Model;
import java.util.Comparator;

public class Compare {
	
	
	/**
	 * Metoda porovnava ci su zadane stavy hlavolamu zhodne
	 * Vracia TRUE ak bola najdena zhoda, inak vracia FALSE
	 * @param aktual
	 * @param end
	 * @return
	 */	
	public static boolean areYouSimmilar (Hlavolam aktual, Hlavolam end) {
		
		for(int i = 0; i < end.m ; i++){
			for(int j = 0; j < end.n ; j++) {
				if(aktual.stav[i][j] != end.stav[i][j])
					return false;
			}
		}
		return true;
	}
	
	/**
	 * Comparator pouzity v PriorityQueue<Hlavolam> 
	 * Urcuje, akym sposobom sa prvky usporiadaju 
	 * Usporiadanie je primarne podla hodnoty heuristickej funkcie
	 * Ak nastane zhoda, dalsim porovnavacim parametrom je hlba uzla
	 */
	public static class PQsort implements Comparator<Hlavolam> {
		@Override
		public int compare(Hlavolam o1, Hlavolam o2) {
			if(o1.heur < o2.heur)
				return -1;
			else if(o1.heur > o2.heur)
				return 1;
			else if(o1.heur == o2.heur){
				if(o1.depth < o2.depth)
					return -1;
				else if(o1.depth > o2.depth)
					return 1;
				else
					return 0;
			}
			return 0;
		}
	}
}
