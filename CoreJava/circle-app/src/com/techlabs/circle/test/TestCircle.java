package com.techlabs.circle.test;

import com.techlabs.circle.*;

public class TestCircle {
	public static void main(String[] args) {
		Circle c1 = new Circle(2.5f);
		displayDetails(c1);

		Circle c2 = new Circle(4.5f, BorderStyleOption.DOUBLE);
		displayDetails(c2);
		
		Circle[] circles= new Circle[3];
		circles[0] = new Circle(5.5f);
		circles[1] = new Circle(5.5f,BorderStyleOption.SINGLE);
		circles[2] = new Circle(5.5f,BorderStyleOption.DOTTED);		
		
		for(Circle circle:circles)
		{
			displayDetails(circle);
		}
	}

	public static void displayDetails(Circle circle) {
		System.out.println("Radius is :" + circle.getRadius());
		System.out.println("Area is :" + circle.calcArea());
		System.out.println("Border Style is :" + circle.getBorderstyle());
		System.out.println("Hash Code is :" + circle.hashCode());
	}

}
