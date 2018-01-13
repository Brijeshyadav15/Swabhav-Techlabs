package com.techlabs.linkednode;

public class Node<T> implements Comparable<T> {

	private T data;
	private Node<T> nextNode;

	public T getData() {
		return data;
	}

	public void setData(T data) {
		this.data = data;
	}

	public Node<T> getNextNode() {
		return nextNode;
	}

	public void setNextNode(Node<T> node) {
		this.nextNode = node;
	}

	@Override
	public int compareTo(T item) {
		return (item == this.data) ? 0 : 1;
	}
}
