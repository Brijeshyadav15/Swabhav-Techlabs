package com.techlabs.employee;

import java.util.*;

public abstract class Employee {
	protected String name;
	protected Date dob;
	protected double basic;

	public String getName() {
		return name;
	}

	public Date getDob() {
		return dob;
	}

	public double getBasic() {
		return basic;
	}

	public Employee(String name, Date dob, double basic) {
		this.name = name;
		this.dob = dob;
		this.basic = basic;
	}

	public float calcAge() {
		Date birthdate = getDob();

		Calendar birthday = Calendar.getInstance();
		birthday.setTimeInMillis(birthdate.getTime());

		long currentTime = System.currentTimeMillis();
		Calendar now = Calendar.getInstance();
		now.setTimeInMillis(currentTime);

		int years = now.get(Calendar.YEAR) - birthday.get(Calendar.YEAR);
		int birthMonth = birthday.get(Calendar.MONTH);
		int currentMonth = now.get(Calendar.MONTH);
		int months = currentMonth - birthMonth;

		if (months < 0) {
			years--;
			months = 12 - birthMonth + currentMonth;
			if (now.get(Calendar.DATE) < birthday.get(Calendar.DATE))
				months--;
			else if (months == 0
					&& now.get(Calendar.DATE) < birthday.get(Calendar.DATE)) {
				years--;
				months = 11;
			}
		}
		return years;
	}

	public abstract double calcNetSalary();
}
