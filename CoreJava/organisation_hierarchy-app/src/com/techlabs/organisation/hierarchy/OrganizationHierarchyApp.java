package com.techlabs.organisation.hierarchy;

public class OrganizationHierarchyApp {
	OrganisationHierarchyBuilder builder;
	EmployeeCSVLoader loader;

	public OrganizationHierarchyApp(OrganisationHierarchyBuilder builder,
			EmployeeCSVLoader loader) {
		this.builder = builder;
		this.loader = loader;
	}

	public void display() {
		Employee CEO = builder.getCEO();
		System.out.println(CEO.getName());
		printReportees(CEO, 10);

	}

	public static void printReportees(Employee employee, int level) {
		for (Employee emp : employee.getReportees()) {
			System.out.println(String.format("%" + level + "s", emp.getName()));
			if (emp.getReportees().size() > 0) {
				printReportees(emp, level + 10);
			}
		}
	}

}
