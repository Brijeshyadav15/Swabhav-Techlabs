package ocp.violation;

public class FixedDeposit {
	private final String name;
	private final double amount;
	private final int period;
	private final FestivalType festival;

	public FixedDeposit(String name, double amount, int period,
			FestivalType festival) {
		super();
		this.name = name;
		this.amount = amount;
		this.period = period;
		this.festival = festival;
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

	public FestivalType getFestival() {
		return festival;
	}

	public double calcInterest() {
		float rate = 0;
		if (getFestival() == FestivalType.NORMAL) {
			rate = 7;
		} else if (getFestival() == FestivalType.DIWALI) {
			rate = 7.5f;
		}
		else if (getFestival() == FestivalType.NEWYEAR) {
			rate = 7.8f;
		}
		return amount * period * rate / 100;
	}
}
