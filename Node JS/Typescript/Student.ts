export class Student
{
    constructor(private rollNo,private name){
    }
    public get Details()
    {
        return `Roll Num : ${this.rollNo} Name:${this.name}`;
    }
}

let s1=new  Student(101,"ABC");
console.log(s1.Details);

