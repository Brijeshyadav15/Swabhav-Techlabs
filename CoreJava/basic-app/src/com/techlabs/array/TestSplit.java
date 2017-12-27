package com.techlabs.array;

public class TestSplit {
	public static void main(String[] urls) {
		if (urls.length > 0) {
			for (String url : urls) {
				String studentarr[] = url.split("=");
				if (studentarr[0].indexOf(".") > 0) {
					int startIndex = studentarr[0].indexOf(".");
					int lastIndex = studentarr[0].lastIndexOf(".");
					String hostname = studentarr[0].substring(startIndex + 1,
							lastIndex);
					System.out.println("Host name is : " + hostname);
					if (studentarr.length > 1) {
						System.out
								.println("Student name is : " + studentarr[1]);
					} else {
						System.out
								.println("No Student name is present in the URL");
					}
				} else {
					System.out.println(url + " is not valid.");
				}
			}
		} else {
			System.out.println("Please enter at least one url");
		}
	}
}
