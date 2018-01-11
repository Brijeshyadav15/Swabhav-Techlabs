package dip.violation;

public class TaxCalculator {
	private Logtype log;

	public TaxCalculator(Logtype log) {
		this.log = log;
	}

	public int calculateTax(int amount, int rate) {
		int result = 0;
		try {
			result = amount / rate;
		} catch (Exception ex) {
			if (log == Logtype.XML)
				new XmlLogger().logError(ex.toString());
			else if (log == Logtype.TXT)
				new TxtLogger().logError(ex.toString());
		}
		return result;
	}
}
