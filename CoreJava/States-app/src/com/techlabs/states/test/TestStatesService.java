package com.techlabs.states.test;

import java.util.*;
import java.util.Map.Entry;

import com.techlabs.states.*;

public class TestStatesService {
	public static void main(String[] args) {
		StateService ss = new StateService();
		Map<String,String> listmap = ss.search("ttar");
		if(listmap.size() > 0)
		{
			System.out.println("Code\t State Name");
			for (Entry<String, String> e : listmap.entrySet())
				System.out.println(e.getKey() + "\t " + e.getValue());
		}
		else{
			System.out.println("No states with Given Code");
		}
	}
}
