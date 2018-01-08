package com.techlabs.collections.set;

import java.util.*;

import com.techlabs.collections.*;
import com.techlabs.collections.test.*;

public class TestTreeSet {
	public static void main(String[] args) {
		casestudyByQuantity();
		casestudyByUnit();

	}

	public static void casestudyByQuantity() {
		Set<LineItem> items = TestLineItem.get();

		Set<LineItem> sort = new TreeSet<LineItem>(new SortLineItemByQuantity());
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

		Set<LineItem> sort = new TreeSet<LineItem>(new SortLineItemByUnitComparator());
		sort.addAll(items);
		sort.add(new LineItem(4, "Product4", 10, 20));
		sort.add(new LineItem(5, "Product5", 15, 20));
		
		System.out.println("Sorted By Unit Price");
		for (LineItem item : sort) {
			System.out.println(item.toString());
		}
	}
}
