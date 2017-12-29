package com.excerise.student;

public class TestDry {

	public static void main(String[] args) {
		Dry d = new Dry();
		d.setUsername("Brijesh");
		d.setPassword("123456");
		System.out.println(d.emaillogin());
		d.setUsername("Akash");
		d.setPassword("65321");
		System.out.println(d.fblogin());
		d.showUser();

	}

}
