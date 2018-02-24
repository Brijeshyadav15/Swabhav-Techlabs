import { Component } from "@angular/core";

@Component({templateUrl:'StudentComponent.html',selector:'ht-student'})
export class StudentComponent{
    someData:string;
    student:any;
    courses=[];

    constructor(){
        this.student = { rollNo :101,
            firstName : 'Brijesh',
            lastName : 'Yadav',
            profilePic :'../assets/student.jpg',
            CGPA:7
        };
        this.someData ='This is SomeData for any view';
    }
    public get Color()
    {
            if(this.student.CGPA  > 8)
                return 'Green';
            else
                return 'Red';          
    }


        LoadCourses($event)
        {         
            console.log("Inside Load Courses");
            this.courses.push('JAVA','HTML','C#')
        }
}