package com.techlabs.organisation.hierarchy.test;

import java.util.List;
import com.techlabs.organisation.hierarchy.Employee;
import com.techlabs.organisation.hierarchy.OrganisationHierarchyBuilder;

public class TestDTO {
	public static void main(String[] args) {
		List<Employee> list = new OrganisationHierarchyBuilder().sortData();
	
		for (Employee li : list) {
			System.out.println(li.getName());
		}
	}
}
