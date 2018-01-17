package com.techlabs.objectrelation.test;

import com.techlabs.objectrelation.Control;
import com.techlabs.objectrelation.ControlGroup;

public class TestObjectRelation {
	public static void main(String[] args) {
		ControlGroup html = new ControlGroup("Html");
		ControlGroup head = new ControlGroup("Head");
		Control title = new Control("Title", "Title");

		ControlGroup body = new ControlGroup("Body");
		ControlGroup header = new ControlGroup("Header");
		ControlGroup footer = new ControlGroup("Footer");
		ControlGroup div = new ControlGroup("Div");

		Control nav = new Control("Nav Bar", "Navbar");
		Control footernav = new Control("Footer Nav Bar", "Footer Navbar");

		footer.add(footernav);
		header.add(nav);

		Control h1 = new Control("Heading 1", "Heading 1");
		Control p = new Control("paragraph", "paragraph");

		ControlGroup form = new ControlGroup("Form");

		Control input = new Control("Input", "Input");
		Control radio = new Control("Radio Button", "radio");

		form.add(input);
		form.add(radio);

		div.add(h1);
		div.add(p);

		body.add(header);
		body.add(footer);
		body.add(div);

		head.add(title);

		html.add(body);
		html.add(head);

		html.showDetails();
	}
}
