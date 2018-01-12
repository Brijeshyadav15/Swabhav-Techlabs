package com.techlabs.singleton.implementation;

public class Singleton {
	private static Singleton instance = new Singleton();

	public Singleton() {

	}

	public static Singleton SingletonInstance() {
		return instance;
	}
}
