package com.techlabs.collections.map;

import java.util.*;

public class TestMap {
	public static void main(String[] args) {
		Map<Integer, String> map;
		map = new HashMap<Integer, String>();
		map.put(1, "Brijesh");
		map.put(4, "Kannan");
		map.put(2, "Akash");
		map.put(7, "Raj");
		map.put(5, "Bhavesh");
		map.put(3, "Deepak");
		map.put(6, "Nirav");
		print(map);

		map = new TreeMap<Integer, String>();
		map.put(1, "Brijesh");
		map.put(4, "Kannan");
		map.put(2, "Akash");
		map.put(7, "Raj");
		map.put(5, "Bhavesh");
		map.put(3, "Deepak");
		map.put(6, "Nirav");
		print(map);

		map = new LinkedHashMap<Integer, String>();
		map.put(1, "Brijesh");
		map.put(2, "Akash");
		map.put(7, "Raj");
		map.put(3, "Deepak");		
		map.put(5, "Bhavesh");
		map.put(6, "Nirav");
		map.put(4, "Kannan");
		
		print(map);

	}

	public static void print(Map<Integer, String> map) {
		for (Map.Entry<Integer, String> ma : map.entrySet()) {
			System.out.println(ma.getKey() + " " + ma.getValue());
		}
		System.out.println();
	}
}
