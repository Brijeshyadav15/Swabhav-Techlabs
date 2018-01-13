package com.techlabs.node.test;

import com.techlabs.linkednode.*;

public class TestLinkedList {

	public static void main(String[] args) {
		SwabhavLinkedList<Integer> node = new SwabhavLinkedList<Integer>();

		node.add(10);
		node.add(30);
		node.addAfter(20, 10);

		node.add(40);
		node.add(60);
		node.addAfter(50, 40);

		node.deleteAfter(50);
		node.print();

		System.out.println("Count is:" +node.count());

	}
	
}
