package com.techlabs.dogdoor.test;


import com.techlabs.dogdoor.*;

public class TestDogDoor {
	public static void main(String[] args) {
		DogDoor door = new DogDoor();
		door.addAllowedBark(new Bark("rowlf"));
		door.addAllowedBark(new Bark("rooowlf"));
		door.addAllowedBark(new Bark("rawlf"));
		door.addAllowedBark(new Bark("woof"));
		BarkRecognizer recognizer = new BarkRecognizer(door);
		Remote remote = new Remote(door);
		System.out.println("Dog starts barking.");
		recognizer.recognize(new Bark("Rowlf"));

		System.out.println("\nDog has gone outside...");

		try {
			Thread.currentThread().sleep(10000);
		} catch (InterruptedException e) {
		}

		System.out.println("\nDog all done...");
		System.out.println("...but he's stuck outside!");

		Bark smallDogBark = new Bark("yip");
		System.out.println("A small dog starts barking.");
		recognizer.recognize(smallDogBark);

		try {
			Thread.currentThread().sleep(5000);
		} catch (InterruptedException e) {
		}

		System.out.println("\nDog starts barking.");
		recognizer.recognize(new Bark("Rowlf"));

		System.out.println("\nDog is back inside...");
	}

}
