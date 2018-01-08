package com.techlabs.employeecsv;

import java.util.Date;

public class Employee {
	private String id;
	private String name;
	private String desg;
	private String reportingid;
	private String dob;
	private int salary;
	private String da;
	private String departmentid;

	public Employee(String id, String name, String desg, String reportingid,
			String dob, int salary, String da, String workingdays) {
		super();
		this.id = id;
		this.name = name;
		this.desg = desg;
		this.reportingid = reportingid;
		this.dob = dob;
		this.salary = salary;
		this.da = da;
		this.departmentid = workingdays;
	}

	public String getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public String getDesg() {
		return desg;
	}

	public String getReportingid() {
		return reportingid;
	}

	public String getDob() {
		return dob;
	}

	public int getBasic() {
		return salary;
	}

	public String getDa() {
		return da;
	}

	public String getWorkingdays() {
		return departmentid;

	}

	@Override
	public String toString() {
		return getId() + " " + getName() + " " + getDesg() + " " + getDob()
				+ " " + getBasic() + " " + getDa() + " " + getWorkingdays();
	}
}
