package com.techlabs.structural.composite.test;

import com.techlabs.structural.composite.File;
import com.techlabs.structural.composite.Folder;

public class TestIDiskItem {
	public static void main(String[] args) {
		Folder movies = new Folder("movies");
		File avengers = new File("Avengers1.mkv", 1.5f, ".mkv");
		movies.addItem(avengers);

		Folder hindimovies = new Folder("Hindi Movies");
		Folder gujaratimovies = new Folder("Gujarati Movies");
		Folder marathimovies = new Folder("Marathi Movies");
		
		File tigerZindaHai = new File("Tiger Zinda Hai.mp4", 2.5f, ".mp4");
		File padmavat = new File("Padmavat.mp4", 1.7f, ".mp4");

		hindimovies.addItem(tigerZindaHai);
		hindimovies.addItem(padmavat);
		
		
		movies.addItem(hindimovies);
		movies.addItem(marathimovies);
		movies.addItem(gujaratimovies);

		movies.showDetails();

	}
}
