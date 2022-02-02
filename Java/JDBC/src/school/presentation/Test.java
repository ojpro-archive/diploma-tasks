package school.presentation;

import java.sql.ResultSet;
import java.sql.SQLException;

public class Test {
	// Connecting credentials
	private static String DB_URL = "jdbc:mysql://localhost/jdbc_presentation";
	private static String DB_USER = "root";
	private static String DB_PASS = "password";

	public static void main(String[] args) {
		// create connection object
		ORM con = new ORM();

		try {

			// use connect method to test ability to connect
			System.out.println(con.connect(DB_URL, DB_USER, DB_PASS));
			System.out.println("Connected");

			ResultSet rs = con.select("*");
			con.display(rs);
			
		} catch (SQLException e) {
			System.out.println("Unable to Connect");
			e.printStackTrace();
		}
	}

}
