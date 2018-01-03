package com.techlabs.hashcode.test;

import com.techlabs.hashcode.HashCode;

public class TestHashCode {

	public static void main(String[] args) {
		HashCode hashcode = new HashCode();
		hashcode.setHash(11);
		hashcode.setHashfloat(1122f);
		System.out.println(hashcode.hashCode());
		System.out.println(hashcode.hashCode());

	}

}
