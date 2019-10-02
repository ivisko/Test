package Model;
import java.util.PriorityQueue;

import View.Window;
import Controller.Counter;

public class Go {
	
	/**
	 * Metoda Start spusta cely proces vypoctu
	 * - vytvara zoznamy navstivenych stavov
	 * - vytvara prioritne rady
	 * - meria cas vypoctu
	 * @param head - pociatocny stav
	 * @param end - koncovy stav
	 * @param counter - pocitadlo
	 */
	public static void Start (Hlavolam head, Hlavolam end, Counter counter){
		
		Hlavolam[] pom1 = new Hlavolam[500];
		Hlavolam[] pom2 = new Hlavolam[500];
		Visit visit1 = new Visit(pom1,0);
		Visit visit2 = new Visit(pom2,0);
		Compare.PQsort pqs = new Compare.PQsort();
		PriorityQueue<Hlavolam> queue1 = new PriorityQueue<Hlavolam>(100,pqs);
		PriorityQueue<Hlavolam> queue2 = new PriorityQueue<Hlavolam>(100,pqs);
		
		long startTimeFP1 = System.nanoTime();
			FindPath(queue1,head,end,counter,visit1,1);   
		long estimatedTimeFP1 = System.nanoTime() - startTimeFP1;
		
		long startTimeFP2 = System.nanoTime();
			counter.ID = 0;
			FindPath(queue2,head,end,counter,visit2,2);   
		long estimatedTimeFP2 = System.nanoTime() - startTimeFP2;
		
		Window.updateTvOperatory("\nCas vypoctu: " + estimatedTimeFP1);
		Window.updateTvOperatory2("\nCas vypoctu: " + estimatedTimeFP2);
		//KONIEC :)
	}
	
	/**
	 * Rekurzivna metoda, ktora generuje a vyhodnocuje stavy hlavolamu
	 * a vyhlada tak postupnost tahov 
	 * @param queue
	 * @param aktual
	 * @param end
	 * @param counter
	 * @param visit
	 * @param h
	 */
	public static void FindPath(PriorityQueue<Hlavolam> queue, Hlavolam aktual, Hlavolam end, Counter counter, Visit visit, Integer h){
		
		boolean theEnd = false;
		boolean was = false;
				
		theEnd = Compare.areYouSimmilar(aktual, end);					//FinalPoint
		if(theEnd == true){
			Integer[] cesta = new Integer[100];
			Vypis.Create(aktual,visit,cesta,0,h);
			return;
		}
		else {
			was = Visit.wasVisit(visit,aktual);							//Visited	
			if(was == true){
				if(queue.isEmpty() == true){
					if(h==1) Window.updateTvOperatory("Cesta neexistuje!\n");
					if(h==2) Window.updateTvOperatory2("Cesta neexistuje!\n"); 
					return;
				}
				aktual = queue.remove();
				FindPath(queue,aktual,end,counter,visit,h); 
			}
			else{														//Generate						
				Hlavolam[] stavy = new Hlavolam[4];	
				stavy = Generate.generujStavy(aktual,end,counter,h,stavy);			
				for(int i = 0; i < 4; i++){
					if(stavy[i] != null)
						queue.add(stavy[i]);
				}
				if(queue.isEmpty() == true){
					if(h==1) Window.updateTvOperatory("Cesta neexistuje\n");
					if(h==2) Window.updateTvOperatory2("Cesta neexistuje\n"); 
					return;
				}
				aktual = queue.remove();
				FindPath(queue,aktual,end,counter,visit,h);
			}
		}				
	}
}
