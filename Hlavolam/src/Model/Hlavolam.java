package Model;
import Controller.Counter;
import View.Window;

/** 
 * Kazdy objekt typu Hlavolam je vyjadrenim urciteho stavu / uzla 
 * Uchovava vsetky potrebne informacie pre vypocet
 *
 */
public class Hlavolam {
	
	public Integer m;
	public Integer n;
	public Integer[][] stav;
	public Integer ID;
	public Integer prev;
	public Integer smer;	// 1 UP * 2 DOWN * 3 RIGHT * 4 LEFT * 0 START/END 
	public Integer heur;
	public Integer depth;
		
	public Hlavolam() {}												
		
	public Hlavolam(Integer m,Integer n,Integer[][] stav, int ID, int prev, Integer smer, Integer heur, Integer depth) {
		this.m = m;					
		this.n = n;													
		this.stav = stav;
		this.ID = ID;
		this.prev = prev;
		this.smer = smer;
		this.heur = heur;
		this.depth = depth;		
	}
	
	/**
	 * Metoda volana stlacenim tlacidla "Pridat(Z)"	
	 * Inicializuje POCIATOCNY stav hlavolamu												
	 * @param head - pociatocny stav
	 * @param counter - pomocne globalne pocitadlo
	 * @param cislo - pridavana hodnota
	 * @return
	 */
	public static Hlavolam initZac(Hlavolam head, Counter counter, int cislo) {	
		
		head.stav[counter.pom1][counter.pom2] = cislo;
		
		Window.updateTvMatica(" " + head.stav[counter.pom1][counter.pom2] + " ");
		if((counter.pom2 + 1) % head.n == 0) 
			Window.updateTvMatica("\n");

		if(counter.pom2 + 1 == head.n){
			counter.pom1++;
			counter.pom2 = 0;
		}
		else
			counter.pom2++;	
		return head;
	}
	
	/**
	 * Metoda volana stlacenim tlacidla "Pridat(K)"
	 * * Inicializuje KONECNY stav hlavolamu													
	 * @param end - konecny stav
	 * @param counter - pomocne globalne pocitadlo
	 * @param cislo - pridavana hodnota
	 * @return
	 */
	public static Hlavolam initKon(Hlavolam end, Counter counter, int cislo) {	
		
		end.stav[counter.pom3][counter.pom4] = cislo;
		
		Window.updateTvMatica2(" " + end.stav[counter.pom3][counter.pom4] + " ");
		if((counter.pom4 + 1) % end.n == 0) 
			Window.updateTvMatica2("\n");

		if(counter.pom4 + 1 == end.n){
			counter.pom3++;
			counter.pom4 = 0;
		}
		else
			counter.pom4++;			
		return end;
	}
	
	/**
	 * Metoda, ktora sluzi na inicializaciu hodnot dvojrozmerneho pola na 0
	 * @param pole - pole, ktore chceme inicializovat
	 * @return
	 */
	public static Integer[][] toNull(Integer[][] pole){	
		for(int i = 0; i < 6; i++){
			for(int j = 0; j < 6; j++){
				pole[i][j] = 0;
			}
		}		
		return pole;
	}
}
