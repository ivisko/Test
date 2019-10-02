package Model;

import View.Window;

public class Vypis {
	
	/**
	 * Metoda spatne vyhlada cestu od cieloveho stavu po pociatocny
	 * @param aktual
	 * @param visit - vyhladavame v zozname navstivenych stavov vzdy podla ID predosleho stavu
	 * @param cesta - pole, v ktorom uchovavame identifikator smeru
	 * @param index
	 * @param h
	 */
	public static void Create(Hlavolam aktual, Visit visit, Integer[] cesta, Integer index, Integer h){			
		
		cesta[index] = aktual.smer;
		if (aktual.prev == 0){
			Vypis.Print(cesta, index, h);
		}
		else {
			for (int i = 0; i < visit.numOfVis ; i++) {
				if(visit.pole[i].ID == aktual.prev) {
					aktual = visit.pole[i];
					Vypis.Create(aktual, visit, cesta, index+1, h);
				}
			}	
		}
	}
	
	/**
	 * Metoda vypise vyslednu postupnost tahov riesenia hlavolamu
	 * @param cesta
	 * @param index
	 * @param h
	 */
	public static void Print (Integer[] cesta, Integer index, Integer h){
		
		Integer ind = index;
		
		while(cesta[ind] != null) {
			
			String smer = null;
			if(cesta[ind] == 1) smer = "HORE (up)";
			else if(cesta[ind] == 2) smer = "DOLE (down)";
			else if(cesta[ind] == 3) smer = "VPRAVO(right)";
			else if(cesta[ind] == 4) smer = "VLAVO (left)";
			else if(cesta[ind] == 0) smer = "_";

			if (h == 1) {
				Window.updateTvOperatory(smer + "\n");
			}
			else if (h == 2) {
				Window.updateTvOperatory2(smer + "\n");
			}
			ind--;
			if(ind<0) return;
		}		
	}
}
