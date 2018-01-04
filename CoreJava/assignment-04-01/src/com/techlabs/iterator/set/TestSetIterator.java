package com.techlabs.iterator.set;

import java.util.*;

public class TestSetIterator {
	public static void main(String[] args) {
		Set<String> cities = new HashSet<String>();
		cities.add("Ahmedabad");
		cities.add("Mumbai");
		cities.add("New Delhi");
		cities.add("Ahmedabad");

		Iterator iterator = cities.iterator();
		while (iterator.hasNext()) {
			System.out.println(iterator.next());
		}
	}
}
