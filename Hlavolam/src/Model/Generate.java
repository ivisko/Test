package Model;
import Controller.Counter;

public class Generate {
	
	/**
	 * Metoda generuje a inicializuje dalsie stavy hlavolamu
	 * V pripade ze sa v danom smere neda vygenerovat dalsi stav nastavi ho na null
	 * Pozn.: stav rovny null sa neprida do PriorityQueue a teda ho neuvazujeme
	 * @param aktual - stav z ktoreho pri generovani vychadzame
	 * @param end - informacie o konecnom stave vyuzivame pri vypocte heuristickej funkcie
	 * @param counter
	 * @param h - nadobuda hodnoty 1/2 - urcuje heuristicku funkciu
	 * @param stavy - pole novych stavov
	 * @return
	 */
	public static Hlavolam[] generujStavy(Hlavolam aktual, Hlavolam end, Counter counter, Integer h, Hlavolam[] stavy) {
		Integer[] pos0 = findZero(aktual);
		stavy[0] = up(aktual,end,counter,pos0,h);
		stavy[1] = down(aktual,end,counter,pos0,h);
		stavy[2] = right(aktual,end,counter,pos0,h);
		stavy[3] = left(aktual,end,counter,pos0,h);
		return stavy;
	}
	
	/**
	 * Metoda vracia polohu medzery v aktualnom stave hlavolamu
	 * @param aktual
	 * @return
	 */
	public static Integer[] findZero(Hlavolam aktual) {		
		Integer[] pos0 = new Integer[3];
		for(int i = 0; i < aktual.m ; i++){
			for(int j = 0; j < aktual.n ; j++) {
				if(aktual.stav[i][j] == 0){
					pos0[0] = i;
					pos0[1] = j;
				}
			}
		}
		return pos0;
	}
//_________________________________________________________________________________UP
	
	public static Hlavolam up(Hlavolam aktual, Hlavolam end, Counter counter, Integer[] pos0, Integer h){		
		
		Hlavolam up = new Hlavolam();
		if(pos0[0] < aktual.m-1){
			up.m = aktual.m;
			up.n = aktual.n;
			up.stav = move_up(aktual,pos0);
			up.ID = ++counter.ID;
			up.prev = aktual.ID;
			up.smer = 1;
			up.heur = Heuristiky.calculate(aktual,end,up.stav,h);
			up.depth = aktual.depth + 1;
		}
		else
			up = null;
		return up;
	}
	private static Integer[][] move_up(Hlavolam aktual,Integer[] pos0) {
		Integer[][] stav = new Integer[6][6];
		for(int i = 0; i < aktual.m ; i++){
			for(int j = 0; j < aktual.n ; j++) {				
				if(i == pos0[0] + 1 && j == pos0[1]){
					stav[i-1][j] = aktual.stav[i][j];
					stav[i][j] = 0;					
				}				
				else if(i != pos0[0] || j != pos0[1])
					stav[i][j] = aktual.stav[i][j];
			}
		}
		return stav;
	}
//_________________________________________________________________________________DOWN
	
	public static Hlavolam down(Hlavolam aktual, Hlavolam end, Counter counter, Integer[] pos0, Integer h){
		Hlavolam down = new Hlavolam();
		if(pos0[0] > 0){
			down.m = aktual.m;
			down.n = aktual.n;
			down.stav = move_down(aktual,pos0);
			down.ID = ++counter.ID;
			down.prev = aktual.ID;
			down.smer = 2;
			down.heur = Heuristiky.calculate(aktual,end,down.stav,h);
			down.depth = aktual.depth + 1;
		}
		else
			down = null;
		return down;
	}
	
	private static Integer[][] move_down(Hlavolam aktual, Integer[] pos0) {
		
		Integer[][] stav = new Integer[6][6];
		for(int i = 0; i < aktual.m ; i++){
			for(int j = 0; j < aktual.n ; j++) {
				if(i == pos0[0] - 1 && j == pos0[1]){
					stav[i+1][j] = aktual.stav[i][j];
					stav[i][j] = 0;
				}
				else if(i != pos0[0] || j != pos0[1])
					stav[i][j] = aktual.stav[i][j];
			}
		}
		return stav;
	}
//_________________________________________________________________________________RIGHT
	
	public static Hlavolam right(Hlavolam aktual, Hlavolam end, Counter counter, Integer[] pos0, Integer h){
		Hlavolam right = new Hlavolam();
		if(pos0[1] > 0){
			right.m = aktual.m;
			right.n = aktual.n;
			right.stav = move_right(aktual,pos0);
			right.ID = ++counter.ID;
			right.prev = aktual.ID;
			right.smer = 3;
			right.heur = Heuristiky.calculate(aktual,end,right.stav,h);
			right.depth = aktual.depth + 1;
		}
		else
			right = null;
		return right;
	}
	private static Integer[][] move_right(Hlavolam aktual, Integer[] pos0) {

		Integer[][] stav = new Integer[6][6];
		for(int i = 0; i < aktual.m ; i++){
			for(int j = 0; j < aktual.n ; j++) {
				if(i == pos0[0] && j == pos0[1] - 1){
					stav[i][j] = 0;
					stav[i][j+1] = aktual.stav[i][j];
				}
				else if(i != pos0[0] || j != pos0[1])
					stav[i][j] = aktual.stav[i][j];
			}
		}
		return stav;
	}
//_________________________________________________________________________________LEFT
	
	public static Hlavolam left(Hlavolam aktual, Hlavolam end, Counter counter, Integer[] pos0, Integer h){
		Hlavolam left = new Hlavolam();
		if(pos0[1] < aktual.n-1){
			left.m = aktual.m;
			left.n = aktual.n;
			left.stav = move_left(aktual,pos0);
			left.ID = ++counter.ID;
			left.prev = aktual.ID;
			left.smer = 4;
			left.heur = Heuristiky.calculate(aktual,end,left.stav,h);
			left.depth = aktual.depth + 1;
		}
		else
			left = null;
		return left;
	}
	private static Integer[][] move_left(Hlavolam aktual, Integer[] pos0) {
		Integer[][] stav = new Integer[6][6];
		for(int i = 0; i < aktual.m ; i++){
			for(int j = 0; j < aktual.n ; j++) {
				if(i == pos0[0] && j == pos0[1] + 1){
					stav[i][j-1] = aktual.stav[i][j];
					stav[i][j] = 0;
				}
				else if(i != pos0[0] || j != pos0[1])
					stav[i][j] = aktual.stav[i][j];
			}
		}
		return stav;
	}

}
