package com.techlabs.linkednode;

import java.util.Iterator;

public class SwabhavLinkedList<T> implements Iterable<T> {
	private Node<T> head;
	private Node<T> tail;

	public void add(T element) {
		Node<T> nd = new Node<T>();
		nd.setData(element);
		if (head == null)
			head = tail = nd;
		else {
			tail.setNextNode(nd);
			tail = nd;
		}
	}

	public void addAfter(T element, T after) {
		Node<T> tmpHead = head;
		Node<T> tmpNode = null;

		while (true) {
			if (tmpHead == null)
				break;
			if (tmpHead.compareTo(after) == 0) {
				tmpNode = tmpHead;
				break;
			}
			tmpHead = tmpHead.getNextNode();
		}

		if (tmpNode != null) {
			Node<T> nd = new Node<T>();
			nd.setData(element);
			nd.setNextNode(tmpHead.getNextNode());
			if (tmpNode == tail)
				tail = nd;
			tmpNode.setNextNode(nd);
		}
	}

	public T deleteFront() {
		if (head == null) 
			return null;

		Node<T> tmp = head;
		head = tmp.getNextNode();
		if (head == null)
			tail = null;
		
		return (T) tmp.getNextNode();
	}

	public T deleteAfter(T after) {
		Node<T> tmpData = head;
		Node<T> tmpNode = null;
		while (true) {
			if (tmpData == null) {
				break;
			}
			if (tmpData.compareTo(after) == 0) {
				tmpNode = tmpData;
				break;
			}
			tmpData = tmpData.getNextNode();
		}
		if (tmpNode != null) {
			tmpData = tmpNode.getNextNode();
			tmpNode.setNextNode(tmpData.getNextNode());
			if (tmpNode.getNextNode() == null) {
				tail = tmpNode;
			}
			return tmpData.getData();
		}
		return null;
	}

	public int count() {
		Node<T> tmp = head;
		int count = 0;
		while (true) {
			if (tmp == null)
				break;

			tmp = tmp.getNextNode();
			count++;
		}
		return count;
	}

	@Override
	public Iterator<T> iterator() {
		return (Iterator<T>) head;
	}

	public void print() {
		Node<T> tmp = head;

		Node<T>[] data = null;
		while (true) {
			if (tmp == null)
				break;

			System.out.println(tmp.getData());
			tmp = tmp.getNextNode();
		}
	}
}
