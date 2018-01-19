package com.techlabs.structural.composite;

public class File implements IDiskItem {
	private String name;
	private float size;
	private String extension;

	public File(String name, float size, String extension) {
		super();
		this.name = name;
		this.size = size;
		this.extension = extension;
	}

	public String getName() {
		return name;
	}

	public float getSize() {
		return size;
	}

	public String getExtension() {
		return extension;
	}

	@Override
	public void showDetails() {
		System.out.println(String.format("%" + Folder.getLevel() + "s", " ")
				+ getName());
	}
}
