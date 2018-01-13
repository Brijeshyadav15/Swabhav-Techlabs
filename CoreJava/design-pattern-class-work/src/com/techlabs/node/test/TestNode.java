package com.techlabs.node.test;

import com.techlabs.linkednode.Employee;
import com.techlabs.linkednode.Node;

public class TestNode {
	public static void main(String[] args) {
		Node<Employee> node1 = new Node<Employee>();
		Node<Employee> node2 = new Node<Employee>();
		Node<Employee> node3 = new Node<Employee>();
		Node<Employee> node4 = new Node<Employee>();

		Employee employee1 = new Employee(1, "Brijesh", 21);
		Employee employee2 = new Employee(2, "Akash", 22);
		Employee employee3 = new Employee(3, "Kannan", 25);

		node1.setData(employee1);
		node1.setNextNode(node2);

		node2.setData(employee2);
		node2.setNextNode(node3);

		node3.setData(employee3);
		node3.setNextNode(null);

		print(node1);
	}

	private static <T> void print(Node<T> node) {
		while (true) {
			if (node == null)
				break;

			Employee employee = (Employee) node.getData();
			System.out.println("Employee ID\t: " + employee.getId());
			System.out.println("Employee Name\t: " + employee.getName());
			System.out.println("Employee Age\t: " + employee.getAge());
			System.out.println();
			node = node.getNextNode();
		}

	}

}
