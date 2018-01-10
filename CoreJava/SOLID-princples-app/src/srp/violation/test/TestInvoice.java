package srp.violation.test;

import srp.violation.Invoice;

public class TestInvoice {
	public static void main(String[] args) {
		Invoice invoice = new Invoice("Brijesh", 100, 15);
		invoice.printInvoice();
	}
}
