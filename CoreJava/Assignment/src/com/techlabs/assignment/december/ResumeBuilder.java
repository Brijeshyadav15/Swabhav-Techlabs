package com.techlabs.assignment.december;

import java.awt.Desktop;
import java.io.*;

public class ResumeBuilder {
	private String name;
	private String mobile;
	private String age;
	private String percentage;
	private String address;

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getMobile() {
		return mobile;
	}

	public void setMobile(String mobile) {
		this.mobile = mobile;
	}

	public String getAge() {
		return age;
	}

	public void setAge(String age) {
		this.age = age;
	}

	public String getPercentage() {
		return percentage;
	}

	public void setPercentage(String percentage) {
		this.percentage = percentage;
	}

	public String getAddress() {
		return address;
	}

	@NeedRefactoring(str = "This method needs refactoring")
	public void setAddress(String address) {
		this.address = address;
	}

	@NeedRefactoring(str = "This method needs refactoring")
	public void buildResume() {
		try {
			File file = new File("Resumes/resume.html");
			FileReader fr = new FileReader(file);
			BufferedReader br = new BufferedReader(fr);
			String iteration;
			String htmldata = null;
			while ((iteration = br.readLine()) != null) {
				htmldata += iteration;
			}
			br.close();
			htmldata = htmldata.replaceAll("null", "");
			htmldata = htmldata.replaceAll("##name##", getName());
			htmldata = htmldata.replaceAll("##age##", getAge());
			htmldata = htmldata.replaceAll("##address##", getAddress());
			htmldata = htmldata.replaceAll("##percentage##", getPercentage());
			htmldata = htmldata.replaceAll("##mobilenumber##", getMobile());
			FileWriter fw = new FileWriter("Resumes/" + getName()
					+ "Resume.html");
			fw.write(htmldata);
			fw.close();
			File resumefile = new File("Resumes/" + getName() + "Resume.html");
			Desktop.getDesktop().browse(resumefile.toURI());
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
