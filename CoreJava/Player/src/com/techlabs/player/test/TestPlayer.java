package com.techlabs.player.test;

import com.techlabs.player.Player;

public class TestPlayer {

	public static void main(String[] args) {
		casestudyone();
		Player p1 = new Player(101, "A", 20);
		Player p2 = new Player(101, "A", 20);
		System.out.println(p1 == p2);
		System.out.println(p1.equals(p2));
	}

	private static void casestudyone() {
		Player sachin = new Player(101, "Sachin", 45);
		Player virat = new Player(102, "Virat");
		System.out.println(sachin.getId());
		System.out.println(virat.getId());
		System.out.println(sachin.getName());
		System.out.println(virat.getName());
		Player elder = sachin.whoIsElder(virat);
		System.out.println("Elder player is :" + elder.getName());
		System.out.println(sachin);
		System.out.println(sachin.toString());
	}

}
