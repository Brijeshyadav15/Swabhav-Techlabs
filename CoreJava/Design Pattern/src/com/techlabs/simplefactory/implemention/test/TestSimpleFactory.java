package com.techlabs.simplefactory.implemention.test;

import com.techlabs.simplefactory.implemention.*;

public class TestSimpleFactory {
	public static void main(String[] args) {
		IFanFactory simplefanfactory = new Fanfactory();
		IFan fan =simplefanfactory.createfaFan(FanType.TABLE);
		fan.switchOff();
		
	}
}
