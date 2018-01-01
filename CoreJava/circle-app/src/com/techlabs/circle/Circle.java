package com.techlabs.circle;

public class Circle {
	private final float radius;
	private static final float pie = 3.14f;
	private BorderStyleOption borderstyle;

	public Circle(float rad) {
		radius = rad;
		borderstyle = BorderStyleOption.SINGLE;
	}

	public Circle(float rad, BorderStyleOption border_style) {
		radius = rad;
		borderstyle = border_style;
	}

	public float getRadius() {
		return radius;
	}

	public BorderStyleOption getBorderstyle() {
		return borderstyle;
	}

	public float calcArea() {
		return 2 * pie * getRadius();
	}

}
