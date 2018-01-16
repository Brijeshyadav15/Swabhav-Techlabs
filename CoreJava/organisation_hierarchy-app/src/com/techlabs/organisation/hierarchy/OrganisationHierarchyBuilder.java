package com.techlabs.organisation.hierarchy;

import java.util.LinkedList;
import java.util.List;

public class OrganisationHierarchyBuilder {
	private List<Employee> employeelist;
	private List<Employee> employeetestlist;

	public OrganisationHierarchyBuilder() {
		employeelist = new EmployeeDTO().getData();
		sortData();
	}

	public List<Employee> sortData() {
		employeetestlist = new LinkedList<Employee>();
		Employee king = null;
		for (Employee employee : employeelist) {
			if (employee.getReportingid().equals("NULL")) {
				employeetestlist.add(employee);
				 king= employee;
			}
		}
		
		employeelist.remove(king);
		
		for (Employee employee : employeelist) {
			if (employee.getReportingid().equals("NULL") == false) {
				if (Integer.parseInt(employee.getReportingid()) == employeetestlist
						.get(0).getId()) {
					employeetestlist.add(employee);
				}
			}
		}

		return employeetestlist;
	}
}
