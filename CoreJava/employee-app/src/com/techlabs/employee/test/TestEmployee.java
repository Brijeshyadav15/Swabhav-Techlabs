package com.techlabs.employee.test;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import com.techlabs.employee.*;

public class TestEmployee {

	public static void main(String[] args) throws ParseException {
		SimpleDateFormat dobformat = new SimpleDateFormat("dd/M/yyyy");

		Employee employee;
		employee = new Manager("Brijesh", dobformat.parse("15/02/1996"), 5000);
		System.out.println(employee.calcAge());
		System.out.println(employee.calcNetSalary());

		employee = new Developer("Aakash", dobformat.parse("15/05/1996"), 5000);
		System.out.println(employee.calcAge());
		System.out.println(employee.calcNetSalary());
	}

}
