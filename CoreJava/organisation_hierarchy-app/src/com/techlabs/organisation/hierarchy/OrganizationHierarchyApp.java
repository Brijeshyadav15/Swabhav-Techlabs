package com.techlabs.organisation.hierarchy;

public class OrganizationHierarchyApp {
	private OrganisationHierarchyBuilder builder;
	private EmployeeCSVLoader loader;
	String parseContent = "\n";

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

	public String parseToXML() {
		Employee CEO = builder.getCEO();
		String content;
		content = "<Employees>";
		content += "\n<RootEmployee name='" + CEO.getName() + "'>";
		content += parseReportees(CEO);
		content += "</RootEmployee>";
		content += "</Employees>";
		return content;
	}

	public void printReportees(Employee employee, int level) {
		for (Employee emp : employee.getReportees()) {
			System.out.println(String.format("%" + level + "s", emp.getName()));
			if (emp.getReportees().size() > 0) {
				printReportees(emp, level + 10);
			}
		}
	}

	public String parseReportees(Employee employee) {
		for (Employee emp : employee.getReportees()) {
			parseContent += "<Employee name='" + emp.getName() + "'>\n";
			if (emp.getReportees().size() > 0) {
				parseReportees(emp);
			}
			parseContent += "</Employee>\n";
		}
		return parseContent;
	}
}
