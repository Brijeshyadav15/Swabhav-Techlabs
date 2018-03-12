import { Component } from '@angular/core';
import { Http, RequestOptions } from '@angular/http';
import {Observable} from 'rxjs/Observable';
import { NgModel, FormGroup, FormControl,ReactiveFormsModule  } from '@angular/forms';
import { HttpHeaders } from '@angular/common/http';
import { UUID } from 'angular2-uuid';
import "rxjs/add/operator/catch";
import "rxjs/add/operator/do";
import "rxjs/add/observable/throw";
import "rxjs/add/operator/map";


@Component({
  selector: 'register-admin',
  templateUrl: 'register.component.html',  
  styleUrls: ['register.component.css']
})
export class RegisterComponent {
  title = 'Shopping Cart Admin';
  name:string;
  email:string;
  password:string;
  confirmpassword:string;
  age:number;
  contact:string;
  location:string;
  imageUrl:string;
  gender:any;
  registerFormGroup :FormGroup;
  constructor(private _http: Http){     
    this.registerFormGroup = new FormGroup({
      nameControl: new FormControl(),
      emailControl:new FormControl(),
      passwordControl: new FormControl(),
      confirmpasswordControl:new FormControl(),
      ageControl:new FormControl(),
      contactControl: new FormControl(),
      locationControl:new FormControl(),
      imageUrlControl:new FormControl(),
      genderControl:new FormControl(),
   });     
  }
  
  registerUser(){
    let result :any;      
    let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/AddUser";  
    let genderval = this.gender == 'Male' ? 0:1;
    let user = {
                "Name":this.name,
                "Email": this.email,
                "ProfilePic":this.imageUrl,
                "Age": this.age,
                "Gender": genderval,
                "Contact": this.contact,
                "Location": this.location,
                "Password": this.password,
                "Role": 1,
                "Id": UUID.UUID()
              }
              console.log(user);
              let headers = new Headers({'Content-Type': 'application/x-www-form-urlencoded'});
              let options = new RequestOptions();
              result = this._http.post(APIURL, user,options).subscribe(res => console.log(res));                 
  }
}
