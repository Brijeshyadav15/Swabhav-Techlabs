package com.techlabs.player;

public class Player {
	private int id;
	private String name;
	private int age;

	public Player(int id, String name) {
		this(id, name, 18);
	}

	public Player(int id, String name, int age) {
		this.id = id;
		this.name = name;
		this.age = age;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public Player whoIsElder(Player player) {
		return this.getAge() > player.getAge() ? this : player;
	}

	@Override
	public String toString() {
		String result = " Id\t:" + getId() + "\n Name\t:" + getName()
				+ " \n Age\t:" + getAge() + " \n Hash\t:" + super.toString();
		return result;
	}

	// @Override
	public boolean equals(Object obj) {
		return this.getId() == ((Player) obj).getId();
	}
}
