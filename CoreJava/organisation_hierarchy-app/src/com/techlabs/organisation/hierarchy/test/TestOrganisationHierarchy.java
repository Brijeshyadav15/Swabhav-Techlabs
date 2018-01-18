package com.techlabs.organisation.hierarchy.test;

import com.techlabs.organisation.hierarchy.EmployeeCSVLoader;
import com.techlabs.organisation.hierarchy.OrganisationHierarchyBuilder;
import com.techlabs.organisation.hierarchy.OrganizationHierarchyApp;

public class TestOrganisationHierarchy {

	public static void main(String[] args) {
		OrganizationHierarchyApp app = new OrganizationHierarchyApp(
				new OrganisationHierarchyBuilder(), new EmployeeCSVLoader());
		// app.display();
		System.out.println(app.parseToXML());

	}

}
