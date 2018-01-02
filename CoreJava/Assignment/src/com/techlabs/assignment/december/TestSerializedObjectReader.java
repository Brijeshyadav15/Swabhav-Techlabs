package com.techlabs.assignment.december;

import java.io.*;

public class TestSerializedObjectReader {
	public static void main(String[] args) {
		try {
			FileInputStream fs = new FileInputStream("Test1.txt");
			ObjectInputStream os = new ObjectInputStream(fs);
			Object object = os.readObject();
			Rectangle rectangle = (Rectangle) object;
			displayDetails(rectangle);
			os.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public static void displayDetails(Rectangle rectangle) {
		System.out.println("Height is:" + rectangle.getHeight());
		System.out.println("Width is:" + rectangle.getWidth());
		System.out.println("Border Color is:" + rectangle.getBordercolor());
		System.out.println("Area is:" + rectangle.calculateArea());
		System.out.println(rectangle.hashCode());
	}
}
