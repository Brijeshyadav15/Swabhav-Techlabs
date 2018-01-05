package com.techlabs.interfaceexample;

public class ShipmentDBLayer implements ICrudable{
	@Override
	public void create() {
		System.out.println("Shipment is creating");
	}

	@Override
	public void read() {
		System.out.println("Shipment is reading");
	}

	@Override
	public void update() {
		System.out.println("Shipment is updating");
	}

	@Override
	public void delete() {
		System.out.println("Shipment is deleting");
	}
}
