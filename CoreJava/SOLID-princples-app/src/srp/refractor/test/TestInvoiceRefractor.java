package srp.refractor.test;

import srp.refractor.Invoice;
import srp.refractor.InvoicePrinter;

public class TestInvoiceRefractor {
	public static void main(String[] args) {
		InvoicePrinter invoiceprinter = new InvoicePrinter();
		invoiceprinter.printInvoice(new Invoice("Brijesh", 150, 15));
	}
}
