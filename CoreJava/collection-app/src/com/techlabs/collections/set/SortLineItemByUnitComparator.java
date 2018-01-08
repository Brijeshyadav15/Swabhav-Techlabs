package com.techlabs.collections.set;

import java.util.Comparator;

import com.techlabs.collections.LineItem;

public class SortLineItemByUnitComparator implements Comparator<LineItem> {

	@Override
	public int compare(LineItem item1, LineItem item2) {
		if (item1.getUnitprice() > item2.getUnitprice()) {
			return -1;
		} else if (item2.getUnitprice() > item1.getUnitprice()) {
			return 1;
		} else if (item1.equals(item2)) {
			return 1;
		}
		return 0;
	}

}
