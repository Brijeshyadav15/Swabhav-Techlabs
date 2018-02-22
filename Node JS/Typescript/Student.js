"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class Student {
    constructor(rollNo, name) {
        this.rollNo = rollNo;
        this.name = name;
    }
    get Details() {
        return `Roll Num : ${this.rollNo} Name:${this.name}`;
    }
}
exports.Student = Student;
let s1 = new Student(101, "ABC");
console.log(s1.Details);
