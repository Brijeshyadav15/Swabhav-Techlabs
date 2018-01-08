package com.techlabs.student.generic;

public class StudentGeneric {
	private int std;
	private int rollno;
	private String name;

	public StudentGeneric(int std, int rollno, String name) {
		super();
		this.std = std;
		this.rollno = rollno;
		this.name = name;
	}

	public int getStd() {
		return std;
	}

	public int getRollno() {
		return rollno;
	}

	public String getName() {
		return name;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + rollno;
		result = prime * result + std;
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		StudentGeneric other = (StudentGeneric) obj;
		if (rollno != other.rollno)
			return false;
		if (std != other.std)
			return false;
		return true;
	}
	
	
}
