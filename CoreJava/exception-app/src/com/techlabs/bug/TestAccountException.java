package com.techlabs.bug;

import com.techlabs.account.exception.*;

public class TestAccountException {
	public static void main(String[] args) {
		Account acc1 = new Account(1, "Brijesh", 1000);
		try {
			acc1.withdraw(5000);
		} catch (Exception ex) {
			System.out.println(ex.getMessage());
		}
	}
}
