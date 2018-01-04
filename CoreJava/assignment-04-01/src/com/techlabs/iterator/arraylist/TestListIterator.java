package com.techlabs.iterator.arraylist;

import java.util.*;

public class TestListIterator {
	public static void main(String[] args) {
		ArrayList<String> names = new ArrayList<String>();
		names.add("Brijesh");
		names.add("Kannan");
		names.add("Akash");
		names.add("Bhavesh");

		Iterator<String> iterator = names.iterator();
		while (iterator.hasNext()) {
			System.out.println(iterator.next());
		}
	}
}
