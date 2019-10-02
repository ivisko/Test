package View;
import java.awt.EventQueue;

import javax.swing.*;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Controller.*;
import Model.Go;
import Model.Hlavolam;

/**
 * Graficke rozhranie
 *
 */

public class Window {

	public JFrame frmhlavolam;
	private JTextField textM;
	private JTextField textN;
	private static JTextArea tvMatica;
	private static JTextArea tvMatica2;
	private static JTextArea tvOperatory;
	private static JTextArea tvOperatory2;
	private JLabel lblZadajPoiatonStav;
	private JTextField textZac;
	private JLabel lblX;
	private JLabel lblPoetPolKtor;
	private JLabel lblManhattanskVzdialenos;
	private JTextField textKon;
	private JButton btnZACPridat;
	private JButton btnKONPridat;
	private JButton btnStart;
	
	private Hlavolam head;
	private Hlavolam finaly;
	private Counter counter;	
	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Window window = new Window();
					window.frmhlavolam.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public Window() {
		initialize();
	}	

	private void initialize() {
		frmhlavolam = new JFrame();
		frmhlavolam.getContentPane().setFont(new Font("Tahoma", Font.PLAIN, 11));
		frmhlavolam.setTitle("Hlavolam");
		frmhlavolam.setBounds(100, 100, 667, 492);
		frmhlavolam.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmhlavolam.getContentPane().setLayout(null);
		
		JLabel lblZadajRozmerHlavolamu = new JLabel("Zadaj rozmer hlavolamu");
		lblZadajRozmerHlavolamu.setFont(new Font("Tahoma", Font.PLAIN, 12));
		lblZadajRozmerHlavolamu.setBounds(10, 0, 173, 27);
		frmhlavolam.getContentPane().add(lblZadajRozmerHlavolamu);
		
		textM = new JTextField();
		textM.setBounds(10, 27, 46, 20);
		frmhlavolam.getContentPane().add(textM);
		textM.setColumns(10);
		
		textN = new JTextField();
		textN.setBounds(85, 27, 46, 20);
		frmhlavolam.getContentPane().add(textN);
		textN.setColumns(10);
		
		lblX = new JLabel("x");
		lblX.setFont(new Font("Tahoma", Font.PLAIN, 15));
		lblX.setBounds(66, 22, 21, 27);
		frmhlavolam.getContentPane().add(lblX);
//________________________________________________________________________________________________btnVYTVOR
/**
 * Tlacidlo, ktore vytvara hlavolam zadanych rozmerov (m*n)		
 */
		JButton btnVytvor = new JButton("Vytvor");
		btnVytvor.setFont(new Font("Tahoma", Font.PLAIN, 10));
		btnVytvor.setForeground(new Color(0, 0, 0));
		btnVytvor.setBackground(Color.WHITE);
		btnVytvor.setBounds(141, 26, 65, 23);
		frmhlavolam.getContentPane().add(btnVytvor);
		
		btnVytvor.addActionListener(new ActionListener() {			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				Integer[][] pom1 = new Integer[6][6];
				Integer[][] pom2 = new Integer[6][6];
				pom1 = Hlavolam.toNull(pom1);	
				pom2 = Hlavolam.toNull(pom2);	
				
				//Start: ID head = 0 = counter.ID, prev-head = -1, ID end = 1000, prev.end = 999
				
				counter = new Counter(0,0,0,0,Integer.parseInt(textM.getText()),Integer.parseInt((textN.getText())),0);				
				head = new Hlavolam(Integer.parseInt(textM.getText()),Integer.parseInt((textN.getText())),pom1,counter.ID,-1,0,0,0);
				finaly = new Hlavolam(Integer.parseInt(textM.getText()),Integer.parseInt((textN.getText())),pom2,1000,999,0,0,0);	
				clearTvMatica("");
				clearTvMatica2("");
				clearTvOperatory("");
				clearTvOperatory2("");	
			}
		});
//_________________________________________________________________________________________________________
		
		lblZadajPoiatonStav = new JLabel("Zadaj po\u010Diato\u010Dn\u00FD stav");
		lblZadajPoiatonStav.setFont(new Font("Tahoma", Font.PLAIN, 12));
		lblZadajPoiatonStav.setBounds(10, 38, 149, 40);
		frmhlavolam.getContentPane().add(lblZadajPoiatonStav);
		
		textZac = new JTextField();
		textZac.setBounds(10, 70, 88, 20);
		frmhlavolam.getContentPane().add(textZac);
		textZac.setColumns(10);
//______________________________________________________________________________________________btnZACIATOK
/**
 * Kazdym stlacenim tlacidla pridame zadany prvok do POCIATOCNEHO stavu hlavolamu		
 */
		btnZACPridat = new JButton("Prida\u0165(Z)");
		btnZACPridat.setForeground(Color.BLACK);
		btnZACPridat.setFont(new Font("Tahoma", Font.PLAIN, 11));
		btnZACPridat.setBackground(Color.WHITE);
		btnZACPridat.setBounds(108, 69, 98, 23);
		frmhlavolam.getContentPane().add(btnZACPridat);
		
		btnZACPridat.addActionListener(new ActionListener() {			
			@Override
			public void actionPerformed(ActionEvent arg0) {	
				if(counter.pom1 != counter.pomM && counter.pom2 != counter.pomN ){
					int cislo = Integer.parseInt(textZac.getText());
					textZac.setText("");
					head = Hlavolam.initZac(head,counter,cislo);
				}
			}
		});
//________________________________________________________________________________________________________
		
		JLabel lblZadajKoncovStav = new JLabel("Zadaj koncov\u00FD stav");
		lblZadajKoncovStav.setFont(new Font("Tahoma", Font.PLAIN, 12));
		lblZadajKoncovStav.setBounds(10, 84, 149, 40);
		frmhlavolam.getContentPane().add(lblZadajKoncovStav);
		
		textKon = new JTextField();
		textKon.setColumns(10);
		textKon.setBounds(10, 116, 88, 20);
		frmhlavolam.getContentPane().add(textKon);
//_______________________________________________________________________________________________btnKONIEC
/**
 * Kazdym stlacenim tlacidla pridame zadany prvok do KONCOVEHO stavu hlavolamu		
 */		
		btnKONPridat = new JButton("Prida\u0165(K)");
		btnKONPridat.setForeground(Color.BLACK);
		btnKONPridat.setFont(new Font("Tahoma", Font.PLAIN, 11));
		btnKONPridat.setBackground(Color.WHITE);
		btnKONPridat.setBounds(108, 115, 98, 23);
		frmhlavolam.getContentPane().add(btnKONPridat);
		
		btnKONPridat.addActionListener(new ActionListener() {			
			@Override
			public void actionPerformed(ActionEvent arg0) {	
				if(counter.pom3 != counter.pomM && counter.pom4 != counter.pomN ){
					int cislo = Integer.parseInt(textKon.getText());
					textKon.setText("");
					finaly = Hlavolam.initKon(finaly,counter,cislo);
				}
			}
		});
//_______________________________________________________________________________________________btnSTART
/**
 * Spustenie hladania cesty		
 */		
		btnStart = new JButton("\u0160tart");
		btnStart.setFont(new Font("Tahoma", Font.PLAIN, 12));
		btnStart.setBackground(Color.WHITE);
		btnStart.setBounds(10, 146, 121, 23);
		frmhlavolam.getContentPane().add(btnStart);
		
		btnStart.addActionListener(new ActionListener() {			
			@Override
			public void actionPerformed(ActionEvent arg0) {	
				Window.updateTvOperatory("Postupnos� operátorov:\n\n");
				Window.updateTvOperatory2("Postupnos� operátorov:\n\n");
				Go.Start(head,finaly,counter);					
			}
		});
//_______________________________________________________________________________________________TextAREA
				
		tvMatica = new JTextArea();
		tvMatica.setFont(new Font("Tahoma", Font.PLAIN, 20));
		tvMatica.setBounds(8, 228, 98, 101);
		frmhlavolam.getContentPane().add(tvMatica);		
		
		tvMatica2 = new JTextArea();
		tvMatica2.setFont(new Font("Tahoma", Font.PLAIN, 20));
		tvMatica2.setBounds(110, 228, 98, 101);
		frmhlavolam.getContentPane().add(tvMatica2);			
		
		lblPoetPolKtor = new JLabel("Po\u010Det pol\u00ED, ktor\u00E9 nie s\u00FA na svojom mieste");
		lblPoetPolKtor.setFont(new Font("Tahoma", Font.PLAIN, 11));
		lblPoetPolKtor.setBounds(234, 13, 224, 14);
		frmhlavolam.getContentPane().add(lblPoetPolKtor);
		
		tvOperatory = new JTextArea();
		tvOperatory.setFont(new Font("Tahoma", Font.PLAIN, 12));
		tvOperatory.setBounds(234, 38, 189, 307);
		frmhlavolam.getContentPane().add(tvOperatory);
		
		lblManhattanskVzdialenos = new JLabel("Manhattansk\u00E1 vzdialenos\u0165");
		lblManhattanskVzdialenos.setFont(new Font("Tahoma", Font.PLAIN, 11));
		lblManhattanskVzdialenos.setBounds(468, 13, 169, 14);
		frmhlavolam.getContentPane().add(lblManhattanskVzdialenos);
		
		tvOperatory2 = new JTextArea();
		tvOperatory2.setFont(new Font("Tahoma", Font.PLAIN, 12));
		tvOperatory2.setBounds(443, 38, 194, 307);
		frmhlavolam.getContentPane().add(tvOperatory2);
//_____________________________________________________________________________________________________
		
		JLabel lblPostav = new JLabel("Po\u010Diato\u010Dn\u00FD stav");
		lblPostav.setFont(new Font("Tahoma", Font.PLAIN, 12));
		lblPostav.setBounds(10, 204, 96, 14);
		frmhlavolam.getContentPane().add(lblPostav);
		
		JLabel lblKoncovStav = new JLabel("Koncov\u00FD stav");
		lblKoncovStav.setFont(new Font("Tahoma", Font.PLAIN, 12));
		lblKoncovStav.setBounds(110, 205, 96, 14);
		frmhlavolam.getContentPane().add(lblKoncovStav);
		
		JLabel lblNavod = new JLabel("1) Zadaj po\u017Eadovan\u00E9 rozmery hlavolamu a stla\u010D tla\u010Didlo \"Vytvor\"");
		lblNavod.setFont(new Font("Tahoma", Font.PLAIN, 11));
		lblNavod.setToolTipText("");
		lblNavod.setBounds(10, 354, 627, 27);
		frmhlavolam.getContentPane().add(lblNavod);
		
		JLabel lblStlaenmTladila = new JLabel("2) Stla\u010Den\u00EDm tla\u010Ddila \"Prida\u0165(Z)\" prid\u00E1\u0161 zadan\u00FA hodnotu do po\u010Diato\u010Dn\u00E9ho stavu hlavolamu");
		lblStlaenmTladila.setFont(new Font("Tahoma", Font.PLAIN, 11));
		lblStlaenmTladila.setToolTipText("");
		lblStlaenmTladila.setBounds(10, 371, 627, 27);
		frmhlavolam.getContentPane().add(lblStlaenmTladila);
		
		JLabel lblStlaenmTladila_1 = new JLabel("3) Stla\u010Den\u00EDm tla\u010Ddila \"Prida\u0165(K)\" prid\u00E1\u0161 zadan\u00FA hodnotu do koncov\u00E9ho stavu hlavolamu");
		lblStlaenmTladila_1.setFont(new Font("Tahoma", Font.PLAIN, 11));
		lblStlaenmTladila_1.setToolTipText("");
		lblStlaenmTladila_1.setBounds(10, 388, 627, 27);
		frmhlavolam.getContentPane().add(lblStlaenmTladila_1);
		
		JLabel lblNamiestoMedzery = new JLabel("4) Namiesto medzery vpisuj \"0\"");
		lblNamiestoMedzery.setFont(new Font("Tahoma", Font.PLAIN, 11));
		lblNamiestoMedzery.setToolTipText("");
		lblNamiestoMedzery.setBounds(10, 402, 627, 27);
		frmhlavolam.getContentPane().add(lblNamiestoMedzery);
		
		JLabel lblTlaidlomtart = new JLabel("5) Tla\u010Didlom \"\u0160tart\" spust\u00ED\u0161 v\u00FDpo\u010Det");
		lblTlaidlomtart.setFont(new Font("Tahoma", Font.PLAIN, 11));
		lblTlaidlomtart.setToolTipText("");
		lblTlaidlomtart.setBounds(10, 417, 627, 27);
		frmhlavolam.getContentPane().add(lblTlaidlomtart);
		
		JLabel background = new JLabel(new ImageIcon ("C:\\Users\\Mária\\Desktop\\FIIT\\2.Bc\\Letný semester (IV.) 2015-2016\\Umelá inteligencia\\color.jpg"));
		background.setBackground(Color.DARK_GRAY);
		background.setFont(new Font("Tahoma", Font.PLAIN, 17));
		background.setBounds(0, 0, 433, 356);
		frmhlavolam.getContentPane().add(background);
	}
//____________________________________________________________________________________________TextAREA
/**	
 * Metody na vypis a mazanie jednotlivych textovych poli
 */
	public static void updateTvMatica(String text) {		
		String pom = tvMatica.getText();
		tvMatica.setText("");
		tvMatica.setText(pom + text);
	}
	
	public static void updateTvMatica2(String text) {		
		String pom = tvMatica2.getText();
		tvMatica2.setText("");
		tvMatica2.setText(pom + text);
	}
	
	public static void clearTvMatica (String text) {
		tvMatica.setText("");
	}
	
	public static void clearTvMatica2 (String text) {
		tvMatica2.setText("");
	}
	
	public static void updateTvOperatory(String text) {
		String pom = tvOperatory.getText();
		tvOperatory.setText(pom + text);
	}
	
	public static void updateTvOperatory2(String text) {
		String pom = tvOperatory2.getText();
		tvOperatory2.setText(pom + text);
	}
	private void clearTvOperatory2(String text) {
		tvOperatory.setText(text);				
	}

	private void clearTvOperatory(String text) {
		tvOperatory2.setText(text);
	}
}
