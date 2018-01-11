package isp.violation.test;
import isp.violation.*;

public class TestIspViolation {
	public static void main(String[] args) {
		atTheCafeteria(new Manager());
		atTheWorkstation(new Manager());
		
		atTheCafeteria(new Robot());
		atTheWorkstation(new Robot());
	}

	private static void atTheWorkstation(IWorker worker) {
		System.out.println("At the Workstation");
		worker.startsWork();
		worker.endsWork();
		
	}

	private static void atTheCafeteria(IWorker worker) {
		System.out.println("At the Cafeteria");
		worker.startsEat();
		worker.endsEat();

	}

}
