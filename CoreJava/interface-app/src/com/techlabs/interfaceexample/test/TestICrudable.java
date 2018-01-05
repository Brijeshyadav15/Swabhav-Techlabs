package com.techlabs.interfaceexample.test;

import com.techlabs.interfaceexample.*;

public class TestICrudable {
	public static void main(String[] args) {
		dodboperation(new CustomerDBLayer());
		dodboperation(new ShipmentDBLayer());
		dodboperation(new InvoiceDBLayer());
	}

	public static void dodboperation(ICrudable x) {
		x.create();
		x.read();
		x.delete();
		x.update();
	}
}
