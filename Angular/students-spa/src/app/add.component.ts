import { StudentService } from './studentsService';
import { Component } from "@angular/core";
import { Router, ActivatedRoute } from "@angular/router";
@Component({templateUrl:'AddComponent.html',selector:'ht-home'})
export class AddComponent{
    age:any;
    date:any;
    email:any;
    name:any;
    rollNo:any;
    isMale:any;
    gender:any;

constructor(private route:ActivatedRoute,private router: Router ,private _apisvc: StudentService){
}
addStudent(){
    this.isMale = this.gender == 'Male' ? true:false;
    let student = {
        "Age": this.age,
        "Date": this.date,
        "Email": this.email,
        "Name": this.name,
        "RollNo": this.rollNo,
        "isMale": this.isMale,
    };
    
    this._apisvc.addStudent(student)
    .then((r)=> {
        console.log("Student Added Successfully");
        alert("Student Added Successfully");
        this.router.navigate(['/Home']);
    });
}
};