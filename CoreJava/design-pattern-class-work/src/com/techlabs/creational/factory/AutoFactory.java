package com.techlabs.creational.factory;

import com.techlabs.creational.singleton.DataService;

public class AutoFactory {
	private static AutoFactory auto_factory = null;

	public void make(AutoMobiles automobile) {
		switch (automobile) {
		case BMW:
			new Bmw().starts();
		case TESLA:
			new Tesla().starts();
		case AUDI:
			new Audi().starts();
		}

	}

	public static AutoFactory getInstance() {
		if (auto_factory == null)
			auto_factory = new AutoFactory();
		return auto_factory;
	}
}
