package com.techlabs.organisation.hierarchy;

import java.util.LinkedHashMap;
import java.util.List;

public class OrganisationHierarchyBuilder {
	private List<Employee> employeelist;
	private EmployeeCSVLoader loader;
	LinkedHashMap<Integer, Employee> employeemap;

	public OrganisationHierarchyBuilder() {
		loader = new EmployeeCSVLoader();
		employeemap = new LinkedHashMap<Integer, Employee>();
	}

	public Employee getCEO() {
		employeelist = loader.convertData();
		for (Employee employee : employeelist) {
			if (employee.getReportingid().equals("NULL") == true) {
				employeemap.put(employee.getId(), employee);
				addReportees(employee);
				break;
			}
		}
		for (Employee employee : employeelist) {
			if (employee.getReportingid().equals("NULL") == false) {
				employeemap.put(employee.getId(), employee);
				addReportees(employee);
			}
		}

		return employeemap.entrySet().iterator().next().getValue();
	}

	public void addReportees(Employee employeeManager) {
		for (Employee employee : employeelist) {
			if (employee.getReportingid().equals("NULL") == false)
				if (Integer.parseInt(employee.getReportingid()) == employeeManager
						.getId())
					employeeManager.addReportee(employee);
		}
	}
}
