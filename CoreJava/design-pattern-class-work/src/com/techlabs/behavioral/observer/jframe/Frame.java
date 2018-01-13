package com.techlabs.behavioral.observer.jframe;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JToggleButton;

public class Frame {
	public static void main(String[] args) {

		JFrame helloFrame = new JFrame("Hello Jframe");
		helloFrame.setSize(350, 200);
		helloFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		JPanel helloPanel = new JPanel();
		helloFrame.add(helloPanel);

		JToggleButton loginButton = new JToggleButton("Hello");
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

		helloFrame.setVisible(true);
	}

	private static void sayHello() {
		System.out.println("Hello Method called");
	}

	private static void sayGoodBye() {
		System.out.println("Goodbye Method called");
	}
}
