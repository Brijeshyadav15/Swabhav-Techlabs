package com.techlabs.student;

import java.io.*;
import java.util.*;

@SuppressWarnings({ "resource" })
public class StudentCsvStore implements IStudentStore {
	ArrayList<Student> studentlist = new ArrayList<Student>();

	public StudentCsvStore() {
		init();
	}

	public void init() {
		try {

			FileReader fr = new FileReader("studentdata.csv");
			BufferedReader br = new BufferedReader(fr);
			String line;
			while ((line = br.readLine()) != null) {
				String[] studentarray = line.split(",");
				studentlist.add(new Student(Long.parseLong(studentarray[0]),
						studentarray[1], Integer.parseInt(studentarray[2]),
						studentarray[3]));
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public ArrayList<Student> get() {
		return studentlist;
	}

	@Override
	public void add(Student student) {
		try {
			studentlist.add(student);
			save();
		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	private void save() {
		try {

			BufferedWriter fos = new BufferedWriter(new FileWriter(
					"studentdata.csv"));
			for (Student student : studentlist) {
				String temp = student.getId() + "," + student.getName() + ","
						+ student.getAge() + "," + student.getLocation();
				fos.append(temp);
				fos.newLine();

			}
			fos.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public Student search(String name) {
		for (Student studentName : studentlist) {
			if (name.equals(studentName.getName()))
				return studentName;
		}
		return null;
	}

	@Override
	public String delete(long id) {
		for (Student studentName : studentlist) {
			if (id == studentName.getId()) {
				studentlist.remove(studentName);
				save();
				return "Student Found by name of :" + studentName.getName();
			}
		}
		return "No Student found with the Given Name";
	}

	@Override
	public void Export() {
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
			for (Student student : studentlist) {
				htmldata = htmldata.replaceAll("null", "");
				htmldata = htmldata.replaceAll("##name##", student.getName());
				// htmldata = htmldata.replaceAll("##age##", student.getAge());
				htmldata = htmldata.replaceAll("##address##",
						student.getLocation());
				FileWriter fw = new FileWriter("Resumes/" + student.getName()
						+ "Resume.html");
				fw.write(htmldata);
				fw.close();
			}
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
