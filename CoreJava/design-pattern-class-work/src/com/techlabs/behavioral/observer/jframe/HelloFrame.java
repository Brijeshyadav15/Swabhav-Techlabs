package com.techlabs.behavioral.observer.jframe;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JToggleButton;

public class HelloFrame extends JFrame {
	private JToggleButton loginButton;
	private JPanel helloPanel;

	public HelloFrame() {
		loginButton = new JToggleButton("Hello");
		helloPanel = new JPanel();
		start();
	}

	public void start() {

		this.setSize(350, 200);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		this.add(helloPanel);

		loginButton.setBounds(10, 80, 80, 25);
		loginButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				sayHello();
			}
		});
		loginButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				sayGoodBye();
			}
		});
		helloPanel.add(loginButton);

		this.setVisible(true);
	}

	private static void sayHello() {
		System.out.println("Hello Method called");
	}

	private static void sayGoodBye() {
		System.out.println("Goodbye Method called");
	}
}
