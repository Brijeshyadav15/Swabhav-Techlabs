package com.techlabs.node.test;

import com.techlabs.linkednode.*;

public class TestLinkedList {

	public static void main(String[] args) {
		SwabhavLinkedList<Integer> nodes = new SwabhavLinkedList<Integer>();

		nodes.add(10);
		nodes.add(30);
		nodes.addAfter(20, 10);

		nodes.add(40);
		nodes.add(60);
		nodes.addAfter(50, 40);

		nodes.deleteAfter(50);
		// node.print();

		System.out.println("Count is: " + nodes.count());

		for (Integer node : nodes) {
			System.out.println(node);
		}

	}
}
