package dip.refractor;

public class TaxCalculator {
	private ILogger log;

	public TaxCalculator(ILogger log) {
		this.log = log;
	}

	public int calculateTax(int amount, int rate) {
		int result = 0;
		try {
			result = amount / rate;
		} catch (Exception ex) {
			log.logError(ex.toString());
		}
		return result;
	}
}
