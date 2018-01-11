package dip.refractor;

public class TxtLogger implements ILogger{
	@Override
	public void logError(String errormsg) {
		System.out.println(errormsg);
	}
}
