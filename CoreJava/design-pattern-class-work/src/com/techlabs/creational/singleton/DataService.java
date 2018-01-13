package com.techlabs.creational.singleton;

public class DataService {
	private static DataService instance = null;

	private DataService() {
		System.out.println("Constructor is called");
	}
	
	public void doWork() {
		System.out.println("Doing task");
		System.out.println(this.hashCode());
	}

	public static DataService getInstance() {
		if (instance == null)
			instance = new DataService();
		return instance;
	}
}
