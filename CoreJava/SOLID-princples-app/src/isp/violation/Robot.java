package isp.violation;

public class Robot implements IWorker {

	@Override
	public void startsWork() {
		System.out.println("Robot starts working");
	}

	@Override
	public void endsWork() {
		System.out.println("Robot ends working");
	}

	@Override
	public void startsEat() {
		throw new RuntimeException("Robots do not eat");
	}

	@Override
	public void endsEat() {
		throw new RuntimeException("Robots do not eat");
	}

}
