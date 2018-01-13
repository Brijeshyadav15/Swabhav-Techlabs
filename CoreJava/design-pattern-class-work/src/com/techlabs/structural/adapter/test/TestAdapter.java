package com.techlabs.structural.adapter.test;

import com.techlabs.structural.adapter.SwabhavQ;

public class TestAdapter {
	public static void main(String[] args) {
		// SwabhavQ<Integer> queue = new SwabhavQ<Integer>();
		// queue.enque(10);
		// queue.enque(20);
		// queue.enque(30);
		// System.out.println("Deque element is:" + queue.deque());
		// for (String item : queue) {
		// System.out.println(item);
		// }

		SwabhavQ<String> queue = new SwabhavQ<String>();
		queue.enque("String1");
		queue.enque("String2");
		queue.enque("String3");

		System.out.println("Deque element is:" + queue.deque());
		for (String item : queue) {
			System.out.println(item);
		}
	}
}
