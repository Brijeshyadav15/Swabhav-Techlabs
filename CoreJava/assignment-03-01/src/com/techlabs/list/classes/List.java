package com.techlabs.list.classes;

public class List {
	private int id;
	private String name;

	public int getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public List(int id, String name) {
		this.id = id;
		this.name = name;
	}
}
