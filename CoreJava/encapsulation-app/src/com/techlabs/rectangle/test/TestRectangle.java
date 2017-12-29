package com.techlabs.rectangle.test;

import com.techlabs.rectangle.*;

public class TestRectangle {
	public static void main(String[] args) {
		Rectangle rectangle1;
		rectangle1 = new Rectangle();
		rectangle1.setHeight(1000);
		rectangle1.setWidth(5);
		rectangle1.setBordercolor("REd");
		displayDetails(rectangle1);

		Rectangle rectangle2 = new Rectangle();
		rectangle2.setHeight(50);
		rectangle2.setWidth(50);
		rectangle2.setBordercolor("Blue");
		displayDetails(rectangle2);

		Rectangle rectangle3 = rectangle1;
		rectangle3.setHeight(25);
		rectangle3.setWidth(35);
		rectangle3.setBordercolor("GREEN");
		displayDetails(rectangle3);
		//rectangle3=null;
		//displayDetails(new Rectangle());
		displayDetails(new Rectangle());

	}

	public static void displayDetails(Rectangle rectangle) {
		System.out.println("Height is:" + rectangle.getHeight());
		System.out.println("Width is:" + rectangle.getWidth());
		System.out.println("Border Color is:" + rectangle.getBordercolor());
		System.out.println("Area is:" + rectangle.calculateArea());
		System.out.println(rectangle.hashCode());		
	}
}
