package com.techlabs.student;

import java.util.*;

public interface IStudentStore {
	public void add(Student student);

	public ArrayList<Student> get();

	public void read();

	public void search(String name);

	public void delete(int id);

}
