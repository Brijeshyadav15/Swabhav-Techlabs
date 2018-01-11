package isp.refractor.test;

import isp.refractor.*;

public class TestIspRefractor {
	public static void main(String[] args) {
		atTheCafeteria(new Manager());
		atTheWorkstation(new Manager());

		atTheWorkstation(new Robot());
	}

	private static void atTheWorkstation(IWorkable worker) {
		System.out.println("At the Workstation");
		worker.startsWork();
		worker.endsWork();

	}

	private static void atTheCafeteria(IEatable worker) {
		System.out.println("At the Cafeteria");
		worker.startsEat();
		worker.endsEat();
	}

}
