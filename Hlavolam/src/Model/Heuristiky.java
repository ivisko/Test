package Model;

public class Heuristiky {
	
	/**
	 * Metoda vycisli hodnotu heuristickej funkcie
	 * Podla parametra h je urcene, ktoru heuristiku pouzijeme
	 * @param aktual
	 * @param end
	 * @param stav
	 * @param h
	 * @return
	 */
	public static Integer calculate(Hlavolam aktual,Hlavolam end, Integer[][] stav, Integer h){
		
		Integer heur = 0;
		Integer pom1 = 0;
		Integer pom2 = 0;
		Integer find = 0;

		/**
		 * Heuristika 1
		 * Hodnotu urcime podla poctu poli, ktore nie su na svojom mieste
		 */
		if(h == 1){
			for(int i = 0; i < end.m ; i++){
				for(int j = 0; j < end.n ; j++) {
					if(stav[i][j] != end.stav[i][j])
						heur++;
				}
			}
			return heur;
		}
		/**
		 * Heuristika 2
		 * Hodnotu vycislime podla Manhattanskej vzdialenosti
		 * t.j.sucet rozdielov pozicii jednotlivych poli a konecnych pozicii
		 */
		else if(h == 2){			
			for(int i = 0; i < end.m ; i++){
				for(int j = 0; j < end.n ; j++) {
					find = stav[i][j];
					for(int k = 0; k < end.m ; k++){
						for(int l = 0; l < end.n ; l++) {
							if(find == end.stav[k][l]){
								if(i>k) pom1 = (i-k);
								else pom1 = (k-i);
								if(j>l) pom2 = (j-l);
								else pom2 = (l-j);
								heur = heur + pom1 + pom2;
								break;
							}
						}
					}
					
				}
			}
		}		
		return heur;
	}

}
