package com.techlabs.creational.singleton.test;

import com.techlabs.creational.singleton.DataService;

public class TestDataService {
	public static void main(String[] args) {
		DataService sv1 = DataService.getInstance();
		DataService sv2 = DataService.getInstance();

		sv1.doWork();
		sv2.doWork();

	}
}
