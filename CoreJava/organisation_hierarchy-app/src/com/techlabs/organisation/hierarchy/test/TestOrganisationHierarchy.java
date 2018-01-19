package com.techlabs.organisation.hierarchy.test;

import com.techlabs.organisation.hierarchy.OrganisationHierarchyBuilder;
import com.techlabs.organisation.hierarchy.OrganizationHierarchyApp;

public class TestOrganisationHierarchy {

	public static void main(String[] args) {
		OrganizationHierarchyApp app = new OrganizationHierarchyApp(
				new OrganisationHierarchyBuilder());
		app.display();
		// System.out.println(app.parseToXML());
		// app.saveToXML("employee");
	}

}
