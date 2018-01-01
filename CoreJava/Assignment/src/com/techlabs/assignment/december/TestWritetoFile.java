package com.techlabs.assignment.december;

import java.io.*;

public class TestWritetoFile {
	public static void main(String[] args) {
		try {
			FileWriter fw = new FileWriter("Test.txt");
			fw.write("TEST STRING");
			fw.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
