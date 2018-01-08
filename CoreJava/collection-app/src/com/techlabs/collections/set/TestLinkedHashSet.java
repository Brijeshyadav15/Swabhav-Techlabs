package com.techlabs.collections.set;

import java.util.Collection;
import java.util.LinkedHashSet;
import java.util.Set;
import java.util.TreeSet;

import com.techlabs.collections.LineItem;
import com.techlabs.collections.test.TestLineItem;

public class TestLinkedHashSet {
	public static void main(String[] args) {
		casestudyByQuantity();
		casestudyByUnit();
	}
	public static void casestudyByQuantity() {
		Set<LineItem> items = TestLineItem.get();

		Set<LineItem> sort = new LinkedHashSet<LineItem>();
		sort.addAll(items);
		sort.add(new LineItem(4, "Product4", 10, 20));
		sort.add(new LineItem(5, "Product5", 15, 20));

		System.out.println("Sorted By Unit Quantity");
		for (LineItem item : sort) {
			System.out.println(item.toString());
		}
	}

	public static void casestudyByUnit() {
		Set<LineItem> items = TestLineItem.get();

		Set<LineItem> sort = new LinkedHashSet<LineItem>();
		sort.addAll(items);
		sort.add(new LineItem(4, "Product4", 10, 20));
		sort.add(new LineItem(5, "Product5", 15, 20));
		
		System.out.println("Sorted By Unit Price");
		for (LineItem item : sort) {
			System.out.println(item.toString());
		}
	}
}
