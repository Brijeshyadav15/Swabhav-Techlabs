package com.techlabs.assignment.december;

import java.lang.annotation.*;

@Retention(RetentionPolicy.RUNTIME)
public @interface NeedRefactoring {
	String str();

}
