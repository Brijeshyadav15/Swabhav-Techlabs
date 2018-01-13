package com.techlabs.simplefactory.implemention;

public class Fanfactory implements IFanFactory {
	public Fanfactory() {
	}

	@Override
	public IFan createfaFan(FanType fan) {
		switch (fan) {
		case CEILING:
			return new Ceiling();
		case TABLE:
			return new Table();
		case EXHAUST:
			return new Exhaust();
		default:
			break;
		}
		return null;
	}
}
