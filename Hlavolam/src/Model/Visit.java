package Model;

public class Visit {
	
	Hlavolam[] pole;
	Integer numOfVis;
	
	public Visit(){}
	
	
	/**
	 * Objekt visit uchovava zoznam vsetkych navstivenych stavov a ich pocet
	 * @param pole
	 * @param numOfVis
	 */
	public Visit(Hlavolam[] pole, Integer numOfVis){
		this.pole = pole;
		this.numOfVis = numOfVis;
	}
	
	
	/**
	 * Metoda wasVisit overuje ci aktualny stav uz bol navstiveny
	 * Vracia TRUE ak navstiveny bol
	 * Ak navstiveny nebol, prida ho do zoznamu navstivenych, zvacsi ich pocet a vracia FALSE
	 * @param visit
	 * @param aktual
	 * @return
	 */
	public static Boolean wasVisit(Visit visit, Hlavolam aktual) {
		boolean was = false;
		if(aktual.ID == 0){
			visit.pole[0] = aktual;
			visit.numOfVis++;
			return false;
		}
		for(int i = 0; i < visit.numOfVis; i++ ){
			was = Compare.areYouSimmilar(visit.pole[i], aktual);			//visited == true ak zisti ze navstiveny bol
			if(was == true){
				return true;
			}
		}		
		visit.pole[visit.numOfVis++] = aktual;	
		return false;
	}

}
