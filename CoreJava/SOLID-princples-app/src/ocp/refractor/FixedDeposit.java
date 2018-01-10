package ocp.refractor;

public class FixedDeposit {
	private final String name;
	private final double amount;
	private final int period;
	IFestivalRate festivalrate;

	public FixedDeposit(String name, double amount, int period,
			IFestivalRate festivalrate) {
		super();
		this.name = name;
		this.amount = amount;
		this.period = period;
		this.festivalrate = festivalrate;
	}

	public String getName() {
		return name;
	}

	public double getAmount() {
		return amount;
	}

	public int getPeriod() {
		return period;
	}

	public double calcInterest() {
		float rate = 0;
		return amount * period * festivalrate.getRate() / 100;
	}
}
