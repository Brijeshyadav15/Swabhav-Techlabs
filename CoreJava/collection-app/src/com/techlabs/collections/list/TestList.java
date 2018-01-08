package com.techlabs.collections.list;

import java.util.*;

public class TestList {
	public static void main(String[] args) {
		List<String> list;
		list = new ArrayList<String>();
		list.add("Brijesh");
		list.add("Akash");
		list.add("Deepak");
		list.add("Kannan");
		list.add("Bhavesh");
		list.add("Nirav");
		list.add("Raj");
		print(list);

		list = new LinkedList<String>();
		list.add("Brijesh");
		list.add("Akash");
		list.add("Deepak");
		list.add("Kannan");
		list.add("Bhavesh");
		list.add("Nirav");
		list.add("Raj");
		print(list);
	}

	public static void print(List<String> list) {
		Iterator<String> iterator = list.iterator();
		while (iterator.hasNext()) {
			System.out.println(iterator.next());
		}
	}

}
