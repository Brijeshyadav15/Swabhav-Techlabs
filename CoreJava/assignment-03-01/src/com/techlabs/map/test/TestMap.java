package com.techlabs.map.test;

import java.util.*;
import java.util.Map.Entry;

import com.techlabs.map.Map;

public class TestMap {

	public static void main(String[] args) {
		casestudyadd();
		// casestudydelete();
		// casestudyupdate();

	}

	private static void casestudyadd() {
		HashMap<Integer, String> map = new HashMap<Integer, String>();
		map.put(1, "Brijesh");
		map.put(2, "Akash");
		for (Entry<Integer, String> m : map.entrySet()) {
			System.out.println(m.getKey() + " " + m.getValue());
		}
	}

	private static void casestudydelete() {
		HashMap<Integer, String> map = new HashMap<Integer, String>();
		map.put(1, "Brijesh");
		map.put(2, "Akash");
		for (Entry<Integer, String> m : map.entrySet()) {
			System.out.println(m.getKey() + " " + m.getValue());
		}
		map.remove(1);
		for (Entry<Integer, String> m : map.entrySet()) {
			System.out.println(m.getKey() + " " + m.getValue());
		}
	}

	private static void casestudyupdate() {
		HashMap<Integer, String> map = new HashMap<Integer, String>();
		map.put(1, "Brijesh");
		map.put(2, "Akash");
		for (Entry<Integer, String> m : map.entrySet()) {
			System.out.println(m.getKey() + " " + m.getValue());
		}
		map.put(3, "Kannan");
		for (Entry<Integer, String> m : map.entrySet()) {
			System.out.println(m.getKey() + " " + m.getValue());
		}
	}
}
