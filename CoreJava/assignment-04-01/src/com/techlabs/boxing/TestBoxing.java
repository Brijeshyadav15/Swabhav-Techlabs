package com.techlabs.boxing;

import java.util.*;

public class TestBoxing {
	public static void main(String[] args) {
		List<Double> ld = new ArrayList<>();
		ld.add(3.11144);

		double pi = ld.get(0);
		System.out.println(pi);
	}
}
