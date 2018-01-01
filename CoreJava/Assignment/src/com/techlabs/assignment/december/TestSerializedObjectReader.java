package com.techlabs.assignment.december;

import java.io.*;


public class TestSerializedObjectReader implements Serializable{
	public static void main(String[] args) {
		try
		{
			FileInputStream fs = new FileInputStream("Test1.txt");
			ObjectInputStream os = new ObjectInputStream(fs);
			Object one = os.readObject();
			Rectangle r1 = (Rectangle) one;
			displayDetails(r1);
			os.close();
		}
		catch(Exception e)
		{
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
