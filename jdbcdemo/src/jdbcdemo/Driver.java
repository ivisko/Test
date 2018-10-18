package jdbcdemo;

import java.sql.*; 
public class Driver {
	public static void main(String[] args) {
		
try {
	//1. Pripojenie na DB
	Connection myConn = DriverManager.getConnection("jdbc:mysql://localhost:3306/demo","","");
	//2. Vytvorenie podmienky
	Statement myStmt = myConn.createStatement();
	//3. Zadanie dopytu
	ResultSet myRs = myStmt.executeQuery("select *from employees");
	//4. Vykon/vypis vysledku 
	while (myRs.next())
		System.out.println(myRs.getString("last_name") + "," + myRs.getString("first_name"));
}
	catch(Exception exc)
{
exc.printStackTrace();		
}
}
}
