package com.techlabs.student;

import java.io.*;
import java.util.*;

public class StudentBinaryStore implements IStudentStore {
	ArrayList<Student> studentlist = new ArrayList<Student>();

	public StudentBinaryStore() {
		init();
	}

	@SuppressWarnings({ "unchecked", "resource" })
	public void init() {
		try {
			FileInputStream fs = new FileInputStream("studentdata.ser");
			studentlist = (ArrayList<Student>) new ObjectInputStream(fs)
					.readObject();
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
		studentlist.add(student);
		save();
		init();
	}

	private void save() {
		try {
			FileOutputStream fos = new FileOutputStream("studentdata.ser");
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(studentlist);
			oos.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public Student search(String name) {
		for (Student studentName : studentlist) {
			if (name.equals(studentName.getName())) {
				return studentName;
			}
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