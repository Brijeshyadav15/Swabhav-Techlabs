package com.techlabs.collections.set;

import java.util.Comparator;

import com.techlabs.collections.LineItem;

public class SortLineItemByQuantity implements Comparator<LineItem> {

	@Override
	public int compare(LineItem item1, LineItem item2) {
		if (item1.getQuantity() > item2.getQuantity()) {
			return -1;
		} else if (item2.getQuantity() > item1.getQuantity()) {
			return 1;
		}
		return -1;
	}
}
