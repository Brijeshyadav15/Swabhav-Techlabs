package com.techlabs.list.test;

import java.util.ArrayList;
import com.techlabs.list.classes.List;

public class TestList {
	public static void main(String[] args) {

		// casestudyadd();
		//casestudydelete();
		//casestudyupdate();
	}

	private static void casestudyadd() {
		ArrayList<List> list = new ArrayList<List>();
		List list1 = new List(1, "Brijesh");
		List list2 = new List(2, "Akash");
		list.add(list1);
		list.add(list2);
		for (List li : list) {
			System.out.println(li.getId() + " " + li.getName());
		}

	}

	private static void casestudydelete() {
		ArrayList<List> list = new ArrayList<List>();
		List list1 = new List(1, "Brijesh");
		List list2 = new List(2, "Akash");
		list.add(list1);
		list.add(list2);
		for (List li : list) {
			System.out.println(li.getId() + " " + li.getName());
		}
		list.remove(list2);
		for (List li : list) {
			System.out.println(li.getId() + " " + li.getName());
		}

	}
	
	private static void casestudyupdate() {
		ArrayList<List> list = new ArrayList<List>();
		List list1 = new List(1, "Brijesh");
		List list2 = new List(2, "Akash");
		list.add(list1);
		list.add(list2);
		for (List li : list) {
			System.out.println(li.getId() + " " + li.getName());
		}
		List list3 = new List(2, "Kannan");
		list.set(1, list3);
		for (List li : list) {
			System.out.println(li.getId() + " " + li.getName());
		}

	}
}
