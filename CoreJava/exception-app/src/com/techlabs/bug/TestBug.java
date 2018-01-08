package com.techlabs.bug;

public class TestBug {
	public static void main(String[] args) {
		int a = Integer.parseInt(args[0]);
		int b= Integer.parseInt(args[1]);
		int c = 0;
		try
		{
			c=a/b;
		}
		catch(ArithmeticException aex)
		{
			aex.printStackTrace();
		}
		catch(NumberFormatException num)
		{
			num.printStackTrace();
		}
		catch(ArrayIndexOutOfBoundsException arex)
		{
			arex.printStackTrace();
		}
		finally{
			System.out.println("Ans is :" +c);
		}
		
	}
}
