import { IStudent } from './IStudent';
import { StudentService } from './studentsService';
import { Component } from "@angular/core";
import { Router,ActivatedRoute } from '@angular/router';

@Component({templateUrl:'EditComponent.html',selector:'ht-edit'})
export class EditComponent{
    isMale:any;
    gender:any;
    rollNo:number;
    student:IStudent;
    ngOnInit(){
        this.rollNo =this.route.snapshot.params['id'];
        
        if(this.rollNo == undefined){
            alert("Please Select a Student First");
            this.router.navigate(['/Home']);
        }

        this._apisvc.getDataById(this.rollNo)
        .subscribe(student => {
            this.student = student;
            this.gender = student.isMale == true ? 'Male' :'Female';
        });   
    }

    constructor(private route:ActivatedRoute,private router: Router ,private _apisvc: StudentService){
        console.log("Gender is" +this.gender);
    }

    editStudent(){
        this.student.isMale = this.gender == 'Male' ? true:false;
        this._apisvc.updateStudent(this.student, this.student.rollNo)
            .then((r)=> {
                console.log("Student Added Successfully");
                alert("Student Added Successfully");
                this.router.navigate(['/Home']);
            });
    }
};