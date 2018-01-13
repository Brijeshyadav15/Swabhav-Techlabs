package com.techlabs.structural.adapter;

import java.util.Iterator;
import java.util.LinkedList;

public class SwabhavQ<T> implements Iterable<T> {
	private LinkedList<T> list = new LinkedList<T>();

	public void enque(T i) {
		list.addLast(i);
	}

	public T deque() {
		return list.removeFirst();
	}

	public int count() {
		return list.size();
	}

	@Override
	public Iterator<T> iterator() {
		return list.iterator();
	}

}
