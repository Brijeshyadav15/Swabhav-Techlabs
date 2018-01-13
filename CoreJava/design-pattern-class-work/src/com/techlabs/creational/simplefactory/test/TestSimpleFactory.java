package com.techlabs.creational.simplefactory.test;

import com.techlabs.creational.simplefactory.AutoFactory;
import com.techlabs.creational.simplefactory.AutoMobiles;

public class TestSimpleFactory {
	public static void main(String[] args) {

		AutoFactory factory = AutoFactory.getInstance();
		factory.make(AutoMobiles.BMW);

		factory.make(AutoMobiles.AUDI);

		factory.make(AutoMobiles.TESLA);
	}
}
