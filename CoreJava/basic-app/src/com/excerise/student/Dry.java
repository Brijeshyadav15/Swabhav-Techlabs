package com.excerise.student;

import java.util.*;

public class Dry {
	private String username;
	private String password;
	ArrayList<String> User = new ArrayList<String>();

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String emaillogin() {
		addUser(getUsername(), getPassword());
		return "You are login through Email LOGIN Method";
	}

	public String fblogin() {
		addUser(getUsername(), getPassword());
		return "You are login through FB LOGIN Method";
	}

	public void addUser(String username, String password) {
		User.add(username);
	}

	public void showUser() {
		for (int i = 0; i < User.size(); i++) {
			System.out.println("Username: " + User.get(i));
		}
	}
}
