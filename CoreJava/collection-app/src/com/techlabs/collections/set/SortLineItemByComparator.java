package com.techlabs.collections.set;

import java.util.Comparator;

import com.techlabs.collections.*;

public class SortLineItemByComparator implements Comparator<LineItem> {

	@Override
	public int compare(LineItem item1, LineItem item2) {
		if (item1.getProduct().equals(item2.getProduct())) {
			return -1;
		} else if(item2.getProduct().equals(item1.getProduct())){
			return 1;
		}
		return 0;
	}

	
}
