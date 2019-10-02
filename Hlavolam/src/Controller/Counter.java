package Controller;

public class Counter {
	
	public int pom1;
	public int pom2;
	public int pom3;
	public int pom4;
	public int pomM;
	public int pomN;
	public int ID;
	
	public Counter(){}
	
	/**
	 * Globalne pocitadlo vyuzivane pri indexovani jednotlivych stavov
	 * @param pom1 - pomocna premenna pri inicializacii pociatocneho stavu hlavolamu 
	 * @param pom2 - pomocna premenna pri inicializacii pociatocneho stavu hlavolamu
	 * @param pom3 - pomocna premenna pri inicializacii koncoveho stavu hlavolamu
	 * @param pom4 - pomocna premenna pri inicializacii koncoveho stavu hlavolamu
	 * @param pomM - zadany rozmer hlavolamu m
	 * @param pomN - zadany rozmer hlavolamu n
	 * @param ID - identifikacne cislo pre kazdy vygenerovany stav
	 */
	public Counter(int pom1, int pom2, int pom3, int pom4, int pomM, int pomN, int ID){
		this.pom1 = pom1;
		this.pom2 = pom2;
		this.pom3 = pom3;
		this.pom4 = pom4;
		this.pomM = pomM;
		this.pomN = pomN;
		this.ID = ID;
	}

}
