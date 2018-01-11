package dip.refractor;

public class XmlLogger implements ILogger {
	@Override
	public void logError(String errormsg) {
		System.out.println(errormsg);
	}
}
