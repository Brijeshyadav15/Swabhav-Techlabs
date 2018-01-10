package ocp.violation.test;

import ocp.violation.*;

public class TestOcpViolation {
	public static void main(String[] args) {
		FixedDeposit fd = new FixedDeposit("Brijesh", 1000, 1,
				FestivalType.NEWYEAR);
		System.out.println("Interest is :" + fd.calcInterest());
	}
}
