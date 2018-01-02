package com.techlabs.assignment.interfaceexample.classes;

import com.techlabs.assignment.interfaceexample.*;

public class Rectangle implements ShapeInterface {
	private int length;
	private int width;

	public int getLength() {
		return length;
	}

	public void setLength(int length) {
		this.length = length;
	}

	public int getWidth() {
		return width;
	}

	public void setWidth(int width) {
		this.width = width;
	}

	@Override
	public int calcArea() {
		return this.getLength() * this.getWidth();
	}

	@Override
	public int calcPerimeter() {
		return 2 * (this.getLength() + this.getWidth());
	}

}
