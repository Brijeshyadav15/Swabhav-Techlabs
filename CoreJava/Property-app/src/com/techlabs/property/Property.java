package com.techlabs.property;

import java.util.*;
import java.io.*;

public class Property {
	public void writeProperty() {

		try {
			Properties prop = new Properties();
			FileOutputStream output = new FileOutputStream("db.properties");

			prop.setProperty("database", "root");
			prop.setProperty("dbuser", "root");
			prop.setProperty("dbpassword", "root@123");

			prop.store(output, null);

		} catch (IOException io) {
			io.printStackTrace();
		}
	}

	public void readProperty() {
		try {
			Properties prop = new Properties();
			FileInputStream input = new FileInputStream("db.properties");

			prop.load(input);

			System.out.println("Database name is :"
					+ prop.getProperty("database"));
			System.out.println("Database User is :"
					+ prop.getProperty("dbuser"));
			System.out.println("Database Password is :"
					+ prop.getProperty("dbpassword"));

		} catch (IOException io) {
			io.printStackTrace();
		}
	}
}