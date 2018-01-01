package com.techlabs.assignment.december;

import java.io.Serializable;

public class Rectangle implements Serializable {
	private int width;
	private int height;
	private String bordercolor;

	public String getBordercolor() {
		return bordercolor;
	}

	public void setBordercolor(String bordercolor) {
		this.bordercolor = validateColor(bordercolor);
	}

	private String validateColor(String color) {
		return color.equalsIgnoreCase("RED") || color.equalsIgnoreCase("BLUE")
				|| color.equalsIgnoreCase("GREEN") ? color : "RED";
	}

	public int getWidth() {
		return width;
	}

	public void setWidth(int width) {
		this.width = validateSide(width);
	}

	public int getHeight() {
		return height;
	}

	public void setHeight(int height) {
		this.height = validateSide(height);
	}

	private int validateSide(int length) {
		if (length > 100)
			return 100;
		else if (length < 0)
			return 1;
		else
			return length;
	}

	public int calculateArea() {
		return getHeight() * getWidth();
	}
}
