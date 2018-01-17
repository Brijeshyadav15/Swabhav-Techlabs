package com.techlabs.objectrelation;

public class Control implements IDomItem {
	private String name;
	private String id;

	public Control(String name, String id) {
		super();
		this.name = name;
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public String getId() {
		return id;
	}

	@Override
	public void showDetails() {
		System.out.println("Control name : " + getName());
		System.out.println("Control name : " + getId());
	}

}
