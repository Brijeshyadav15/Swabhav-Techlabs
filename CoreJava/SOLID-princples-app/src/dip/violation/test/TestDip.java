package dip.violation.test;

import dip.violation.*;

public class TestDip {
	public static void main(String[] args) {
		TaxCalculator taxcalculator = new TaxCalculator(Logtype.XML);
		System.out.println(taxcalculator.calculateTax(10, 5));
		
		TaxCalculator taxcalculator1 = new TaxCalculator(Logtype.TXT);
		System.out.println(taxcalculator1.calculateTax(0, 0));
	}
}
