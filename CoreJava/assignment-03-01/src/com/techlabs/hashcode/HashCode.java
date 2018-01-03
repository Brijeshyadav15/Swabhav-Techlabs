package com.techlabs.hashcode;

public class HashCode {
	private int hash;
	private float hashfloat;

	public float getHashfloat() {
		return hashfloat;
	}

	public void setHashfloat(float hashfloat) {
		this.hashfloat = hashfloat;
	}

	public int getHash() {
		return hash;
	}

	public void setHash(int hash) {
		this.hash = hash;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + hash;
		result = prime * result + Float.floatToIntBits(hashfloat);
		return result;
	}
}
