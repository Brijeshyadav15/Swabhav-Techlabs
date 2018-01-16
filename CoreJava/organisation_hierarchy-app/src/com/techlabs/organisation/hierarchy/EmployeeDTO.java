package com.techlabs.organisation.hierarchy;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class EmployeeDTO {
	private Set<String> employeeset;
	private List<Employee> employeelist;

	public EmployeeDTO() {
		employeeset = new HashSet<String>();
		employeelist = new ArrayList<Employee>();
		init();
	}

	public void init() {
		try {
			FileReader fr = new FileReader("dataFile.txt");
			BufferedReader br = new BufferedReader(fr);
			String line;
			while ((line = br.readLine()) != null) {
				employeeset.add(line);
			}
			br.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public List<Employee> getData() {
		for (String employee : employeeset) {
			String[] emp1 = employee.split(",");

			emp1[1] = emp1[1].replace("'", "");
			emp1[2] = emp1[2].replace("'", "");
			emp1[3] = emp1[3].replace("'", "");
			emp1[4] = emp1[4].replace("'", "");
			Employee e = new Employee(Integer.parseInt(emp1[0]), emp1[1],
					emp1[2], emp1[3], emp1[4], Integer.parseInt(emp1[5]),
					emp1[6], emp1[7]);
			employeelist.add(e);
		}
		return employeelist;
	}
}
