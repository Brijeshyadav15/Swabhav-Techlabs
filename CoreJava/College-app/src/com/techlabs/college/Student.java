package com.techlabs.college;

import java.util.*;

public class Student extends Person  {
	private int id;
	private String address;
	private Date dob;
	private Branch branch;

	public Student(int id, String address, Date dob, Branch branch) {
		super();
		this.id = id;
		this.address = address;
		this.dob = dob;
		this.branch = branch;
	}

	public int getId() {
		return id;
	}

	public String getAddress() {
		return address;
	}

	public Date getDob() {
		return dob;
	}

	public Branch getBranch() {
		return branch;
	}
}
