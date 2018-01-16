package com.techlabs.organisation.hierarchy;

public class Employee {
	private int id;
	private String name;
	private String desg;
	private String reportingid;
	private String dob;
	private int salary;
	private String da;
	private String departmentid;

	public Employee(int id, String name, String desg, String reportingid,
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

	public int getId() {
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
}
