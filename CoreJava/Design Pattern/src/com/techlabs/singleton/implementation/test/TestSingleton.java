package com.techlabs.singleton.implementation.test;

import com.techlabs.singleton.implementation.Singleton;

public class TestSingleton {
	public static void main(String[] args) {
		Singleton singleton = new Singleton();
		System.out.println(singleton.SingletonInstance());
		
	}
}
