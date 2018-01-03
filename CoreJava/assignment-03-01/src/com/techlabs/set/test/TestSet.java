package com.techlabs.set.test;

import java.util.*;

import com.techlabs.set.Set;

public class TestSet {

	public static void main(String[] args) {
		casestudyadd();
		casestudydelete();
		casestudyupdate();

	}

	private static void casestudyadd() {
		HashSet<Set> set = new HashSet<Set>();
		Set set1 = new Set(1, "Brijesh");
		Set set2 = new Set(2, "Akash");
		set.add(set1);
		set.add(set2);
		for (Set s : set) {
			System.out.println(s.getId() + " " + s.getName());
		}

	}

	private static void casestudydelete() {
		HashSet<Set> set = new HashSet<Set>();
		Set set1 = new Set(1, "Brijesh");
		Set set2 = new Set(2, "Akash");
		set.add(set1);
		set.add(set2);
		for (Set s : set) {
			System.out.println(s.getId() + " " + s.getName());
		}
		set.remove(set1);
		for (Set s : set) {
			System.out.println(s.getId() + " " + s.getName());
		}

	}

	private static void casestudyupdate() {
		HashSet<Set> set = new HashSet<Set>();
		Set set1 = new Set(1, "Brijesh");
		Set set2 = new Set(2, "Akash");
		set.add(set1);
		set.add(set2);
		for (Set s : set) {
			System.out.println(s.getId() + " " + s.getName());
		}
		Set set3 = new Set(3, "Kannan");
	}
}
