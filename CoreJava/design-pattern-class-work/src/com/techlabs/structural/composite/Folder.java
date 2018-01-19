package com.techlabs.structural.composite;

import java.util.ArrayList;
import java.util.List;

public class Folder implements IDiskItem {
	private List<IDiskItem> items;
	private String name;
	private static int level = 1;

	public static int getLevel() {
		return level;
	}

	public static void setLevel(int level) {
		Folder.level = level;
	}

	public Folder(String name) {
		this.name = name;
		items = new ArrayList<IDiskItem>();
	}

	public String getName() {
		return name;
	}

	public void addItem(IDiskItem item) {
		items.add(item);
	}

	public List<IDiskItem> getItems() {
		return items;
	}

	@Override
	public void showDetails() {
		System.out.println(String.format("%" + level + "s", " ") + getName());
		level = level + 10;
		for (IDiskItem item : items) {
			item.showDetails();
		}
	}

}
