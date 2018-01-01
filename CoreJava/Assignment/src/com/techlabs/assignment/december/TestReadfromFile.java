package com.techlabs.assignment.december;

import java.io.*;

public class TestReadfromFile {
	public static void main(String[] args) {
		try {
			File file = new File("Test.txt");
			FileReader fr = new FileReader(file);
			BufferedReader br = new BufferedReader(fr);
			String iteration;
			while ((iteration = br.readLine()) != null) {
				System.out.println(iteration);
			}
			br.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
