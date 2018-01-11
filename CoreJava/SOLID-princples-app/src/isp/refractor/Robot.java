package isp.refractor;

public class Robot implements IWorkable {

	@Override
	public void startsWork() {
		System.out.println("Robot starts working");
	}

	@Override
	public void endsWork() {
		System.out.println("Robot ends working");
	}
}
