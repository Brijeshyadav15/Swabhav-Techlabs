package com.techlabs.interfaceexample.test;

import com.techlabs.interfaceexample.*;

public class TestIcrudable {
	public static void main(String[] args) {
		dodboperation(new Customer());
		dodboperation(new Shipment());
		dodboperation(new Invoice());
	}

	public static void dodboperation(Icrudable x) {
		x.create();
		x.read();
		x.delete();
		x.update();
	}
}
