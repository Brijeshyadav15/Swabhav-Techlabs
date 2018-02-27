import { Router } from '@angular/router';
import { Component, ChangeDetectorRef } from "@angular/core";
import { StudentService } from "./studentsService";
import { IStudent } from "./IStudent";

@Component({templateUrl:'HomeComponent.html',selector:'ht-home'})
export class HomeComponent{
    students:IStudent;
    numberOfTicks:number= 0;
    constructor(private _apisvc: StudentService,private router: Router){
    }

    ngOnInit() {        
        this.getStudents();
    }

    getStudents(){
        this._apisvc.getData()
        .subscribe(students => this.students = students);
    }
    
    deleteStudent(e){
        this._apisvc.deleteStudent(e)
        .then((r)=> {
            console.log("Student Deleted Successfully");
            alert("Student Deleted Successfully");
        });
        this.ngOnInit();
    }
};