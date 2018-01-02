package com.techlabs.assigment.interfaceexample.test;

import com.techlabs.assignment.interfaceexample.classes.*;

public class TestShapeInterface {
	public static void main(String[] args) {
		Circle circle = new Circle();
		circle.setRadius(10);
		System.out.println(circle.calcArea());
		System.out.println(circle.calcPerimeter());

		Rectangle rectangle = new Rectangle();
		rectangle.setLength(10);
		rectangle.setWidth(20);
		System.out.println(rectangle.calcArea());
		System.out.println(rectangle.calcPerimeter());
	}
}
