package isp.violation;

public class Manager implements IWorker {

	@Override
	public void startsWork() {
		System.out.println("Manager starts working");
	}

	@Override
	public void endsWork() {
		System.out.println("Manager ends working");
	}

	@Override
	public void startsEat() {
		System.out.println("Manager starts eating");
	}

	@Override
	public void endsEat() {
		System.out.println("Manager stops eating");
	}

}
