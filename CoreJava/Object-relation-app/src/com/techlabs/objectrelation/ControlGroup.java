package com.techlabs.objectrelation;

import java.util.ArrayList;
import java.util.List;

public class ControlGroup implements IDomItem {
	private String name;
	private List<IDomItem> items = null;
	

	private static int level = 1;

	public ControlGroup(String name) {
		this.name = name;
		items = new ArrayList<IDomItem>();
	}

	public String getName() {
		return name;
	}
	public List<IDomItem> getItems() {
		return items;
	}

	public void add(IDomItem item) {
		items.add(item);
	}

	
	public void showDetails(List<IDomItem> parentitems) {
		
		System.out.println(String.format("%" + level + "s", " ") + getName());
		level = level + 10;
		System.out.println(parentitems.indexOf(getItems().get(2)));
		
		for (IDomItem item : items) {
			
			item.showDetails();
		}

	}

	@Override
	public void showDetails() {
		// TODO Auto-generated method stub
		
	}

}
