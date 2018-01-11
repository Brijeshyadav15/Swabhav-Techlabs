package dip.refractor.test;

import dip.refractor.*;

public class TestDipRefractor {
	public static void main(String[] args) {
		TaxCalculator taxcalculator = new TaxCalculator(new XmlLogger());
		System.out.println(taxcalculator.calculateTax(10, 5));
		
		TaxCalculator taxcalculator1 = new TaxCalculator(new TxtLogger());
		System.out.println(taxcalculator.calculateTax(0, 0));
	}
}
