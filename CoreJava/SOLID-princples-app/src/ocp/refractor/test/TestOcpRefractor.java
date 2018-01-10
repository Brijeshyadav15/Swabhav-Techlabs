package ocp.refractor.test;

import ocp.refractor.*;

public class TestOcpRefractor {
	public static void main(String[] args) {
		FixedDeposit fd = new FixedDeposit("Brijesh", 1000, 1,
				new NewYearRate());
		System.out.println("Interest is :" + fd.calcInterest());
	}
}
