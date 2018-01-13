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
		if (head == null) {
			return null;
		}
		Node<T> tmp = head;
		head = tmp.getNextNode();
		if (head == null)
			tail = null;

		return (T) tmp.getNextNode();
	}

	public T deleteAfter(T after) {
		Node<T> tmp = head;
		Node<T> refNode = null;
		while (true) {
			if (tmp == null) {
				break;
			}
			if (tmp.compareTo(after) == 0) {
				refNode = tmp;
				break;
			}
			tmp = tmp.getNextNode();
		}
		if (refNode != null) {
			tmp = refNode.getNextNode();
			refNode.setNextNode(tmp.getNextNode());
			if (refNode.getNextNode() == null) {
				tail = refNode;
			}
			return tmp.getData();
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
			if (tmp == null) {
				break;
			}
			System.out.println(tmp.getData());
			tmp = tmp.getNextNode();
		}
	}

}
