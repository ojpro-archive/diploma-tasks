package school.presentation;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class ORM {
	// create empty connection object
	Connection connect = null;

	// method to connect to a specified database
	public Connection connect(String DB_URL, String DB_USER, String DB_PASS) throws SQLException {
		// Get A connection
		connect = DriverManager.getConnection(DB_URL, DB_USER, DB_PASS);
		// return the connection's object
		return connect;
	}

	public ResultSet select(String rows) throws SQLException {
		// Select query to fetch [rows]
		String select_query = "SELECT " + rows + " FROM Students";

		// prepare for sending a request
		Statement stmt = this.connect.createStatement();

		// store fetched data as ResutltSet
		ResultSet response = stmt.executeQuery(select_query);
		// return fetched data
		return response;

	}

	public void update(String column, String value, int forId) throws SQLException {
		String update_query = "UPDATE Students SET " + column + "='" + value + "' WHERE id=" + forId;

		// prepare for sending a request
		Statement stmt = this.connect.createStatement();

		stmt.executeUpdate(update_query);
	}

	public void insert(String name, String email, String password) throws SQLException {
		String insert_query = "INSERT INTO Students VALUES(NULL,'" + name + "','" + email + "','" + password + "')";
		// prepare for sending a request
		Statement stmt = this.connect.createStatement();

		stmt.executeUpdate(insert_query);
	}

	// not dynamic i know ;)
	public void display(ResultSet rs) throws SQLException {
		// loop though the rs
		while (rs.next()) {
			System.out
					.println(rs.getString("name") + "\t\t" + rs.getString("email") + "\t\t" + rs.getString("password"));
		}
	}

	// Ex: Delete Method
}
