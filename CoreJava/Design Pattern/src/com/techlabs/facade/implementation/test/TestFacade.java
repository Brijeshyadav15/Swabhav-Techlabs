package com.techlabs.facade.implementation.test;

import com.techlabs.facade.implementation.*;

public class TestFacade {
	public static void main(String[] args) {
		ShapeMaker shapemaker = new ShapeMaker();
		shapemaker.drawCircle();
		shapemaker.drawRectangle();
		shapemaker.drawSquare();
	}
}
