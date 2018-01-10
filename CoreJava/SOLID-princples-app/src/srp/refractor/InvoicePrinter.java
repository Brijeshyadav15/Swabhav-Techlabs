package srp.refractor;

public class InvoicePrinter {
	public void printInvoice(Invoice invoice) {
		System.out.println("Invoice ID \t\t: " + invoice.getId());
		System.out.println("Customer name \t\t: " + invoice.getName());
		System.out.println("Cost Price \t\t: " + invoice.getCost());
		System.out.println("Discounted Price \t: " + invoice.calcDiscount());
		System.out.println("Tax on this product \t: " + invoice.calcTax());
		System.out.println("Total \t\t\t: " + invoice.calcTotal());
	}
}
