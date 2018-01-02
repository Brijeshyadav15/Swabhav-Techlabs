package com.techlabs.assignment.december;

import java.io.*;

public class TestSerializedObjectWriter {
	public static void main(String[] args) {
		Rectangle r1 = new Rectangle();
		r1.setWidth(100);
		r1.setHeight(50);
		r1.calculateArea();

		try {
			FileOutputStream fos = new FileOutputStream("Test1.txt");
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(r1);
			oos.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
