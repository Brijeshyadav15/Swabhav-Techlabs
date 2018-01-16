 package com.techlabs.employeecsv;

import java.io.*;
import java.util.*;

public class EmployeeService {
	Set<Employee> employeeset = new HashSet<Employee>();

	public void init() {

		try {
			FileReader fr = new FileReader("dataFile.txt");
			BufferedReader br = new BufferedReader(fr);
			String line;
			while ((line = br.readLine()) != null) {
				String[] emp1 = line.split(",");

				emp1[1] = emp1[1].replace("'", "");
				emp1[2] = emp1[2].replace("'", "");
				emp1[3] = emp1[3].replace("'", "");
				emp1[4] = emp1[4].replace("'", "");
				Employee e = new Employee(emp1[0], emp1[1], emp1[2], emp1[3],
						emp1[4], Integer.parseInt(emp1[5]), emp1[6], emp1[7]);
				employeeset.add(e);
			}
			br.close();

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public Set<Employee> get() {
		return employeeset;
	}

}
