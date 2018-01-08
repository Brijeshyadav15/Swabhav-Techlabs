package com.techlabs.employeecsv.test;

import java.util.*;

import com.techlabs.employeecsv.*;

public class TestEmployeeService {
	public static void main(String[] args) {
		casestudybySortByName();
		casestudybySortSalary();
	}

	private static void casestudybySortSalary() {
		EmployeeService emp = new EmployeeService();
		emp.init();
		Set<Employee> emps = emp.get();
		Set<Employee> empset = new TreeSet<Employee>(new SortBySalary());
		empset.addAll(emps);
		System.out.println("Sorted by  Name are:");
		for (Employee employee : empset) {
			System.out.println(employee.toString());
		}

	}

	private static void casestudybySortByName() {
		EmployeeService emp = new EmployeeService();
		emp.init();
		Set<Employee> emps = emp.get();
		Set<Employee> empset = new TreeSet<Employee>(new SortByName());
		empset.addAll(emps);
		System.out.println("Sorted by Salary are:");
		for (Employee employee : empset) {
			System.out.println(employee.toString());
		}

	}
}
