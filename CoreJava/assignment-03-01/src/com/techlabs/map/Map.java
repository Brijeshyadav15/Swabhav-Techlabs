package com.techlabs.map;

public class Map {
	private int id;
	private String name;

	public Map(int id, String name) {
		this.id = id;
		this.name = name;
	}

	public int getId() {
		return id;
	}

	public String getName() {
		return name;
	}
}