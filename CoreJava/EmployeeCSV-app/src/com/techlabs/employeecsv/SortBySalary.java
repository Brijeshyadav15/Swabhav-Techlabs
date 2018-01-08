package com.techlabs.employeecsv;

import java.util.Comparator;

public class SortBySalary implements Comparator<Employee> {

	@Override
	public int compare(Employee emp1, Employee emp2) {
		if (emp1.getBasic() > emp2.getBasic()) {
			return 1;
		} else if (emp2.getBasic() > emp1.getBasic()) {
			return -1;
		} else if (emp1.getBasic() == emp2.getBasic()) {
			return 1;
		}
		return 0;
	}

}
