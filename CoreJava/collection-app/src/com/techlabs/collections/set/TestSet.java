package com.techlabs.collections.set;

import java.util.*;

public class TestSet {
	public static void main(String[] args) {
		Set<String> set;
		set = new HashSet<String>();
		set.add("Brijesh");
		set.add("Akash");
		set.add("Deepak");
		set.add("Kannan");
		set.add("Bhavesh");
		set.add("Nirav");
		set.add("Raj");
		print(set);

		set = new TreeSet<String>();
		set.add("Brijesh");
		set.add("Akash");
		set.add("Deepak");
		set.add("Kannan");
		set.add("Bhavesh");
		set.add("Nirav");
		set.add("Raj");
		print(set);
		
		set = new LinkedHashSet<String>();
		set.add("Brijesh");
		set.add("Akash");
		set.add("Deepak");
		set.add("Kannan");
		set.add("Bhavesh");
		set.add("Nirav");
		set.add("Raj");
		print(set);
	}

	public static void print(Set<String> set) {
		Iterator<String> setiterator = set.iterator();
		while (setiterator.hasNext()) {
			System.out.println(setiterator.next());
		}
		System.out.println();
	}
}
