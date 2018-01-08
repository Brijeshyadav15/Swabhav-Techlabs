package com.techlabs.states;

import java.io.*;
import java.util.*;
import java.util.Map.Entry;

public class StateService {
	Map<String, String> statelist = new HashMap<String, String>();

	public StateService() {
		init();
	}

	public void init() {
		try {
			FileReader fr = new FileReader("States.csv");
			BufferedReader br = new BufferedReader(fr);
			String list;
			while ((list = br.readLine()) != null) {
				String[] details = list.split(",");
				statelist.put(details[0], details[1]);
			}
			br.close();
		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	public Map<String, String> search(String code) {
		code=code.toUpperCase();
		Map<String, String> temp = new HashMap<String, String>();
		for (Entry<String, String> state : statelist.entrySet()) {
			if (code.length() == 1
					&& state.getKey().startsWith(
							String.valueOf((code.charAt(0))))) {
				temp.put(state.getKey(), state.getValue());
			} else if (code.length() == 2 && statelist.containsKey(code)) {
				temp.put(code, statelist.get(code));
			} else if (state.getValue().contains(code)) {
				temp.put(code, state.getValue());
			}
		}
		return temp;
	}
}
