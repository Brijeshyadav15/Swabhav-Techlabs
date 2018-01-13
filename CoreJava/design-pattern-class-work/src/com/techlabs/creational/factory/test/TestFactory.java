package com.techlabs.creational.factory.test;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Properties;

import com.techlabs.creational.factory.IAutoFactory;
import com.techlabs.creational.factory.IAutomobile;

public class TestFactory {
	public static void main(String[] args) throws InstantiationException,
			IllegalAccessException, ClassNotFoundException {
		// writeProperty();
		IAutoFactory factory = createFactory();

		IAutomobile car = factory.make();
		car.starts();
		car.stops();
	}

	private static IAutoFactory createFactory() throws InstantiationException, IllegalAccessException, ClassNotFoundException {
		try {
			Properties prop = new Properties();
			FileInputStream input = new FileInputStream("factory.properties");

			prop.load(input);
			return (IAutoFactory) Class.forName(prop.getProperty("factory")).newInstance();

		} catch (IOException io) {
			io.printStackTrace();
		}
		return null;
	}

	private static void writeProperty() {

		try {
			Properties prop = new Properties();
			FileOutputStream output = new FileOutputStream("factory.properties");

			prop.setProperty("factory",
					new com.techlabs.creational.factory.BMWFactory().toString());
			prop.store(output, null);

		} catch (IOException io) {
			io.printStackTrace();
		}
	}
}
