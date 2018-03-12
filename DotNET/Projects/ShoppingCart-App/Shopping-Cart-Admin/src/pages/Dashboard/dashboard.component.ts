import { Component } from '@angular/core';
import { Http, RequestOptions } from '@angular/http';
import {Observable} from 'rxjs/Observable';
import { NgModel, FormGroup, FormControl,ReactiveFormsModule  } from '@angular/forms';
import { EmailValidator } from '@angular/forms';
import "rxjs/add/operator/catch";
import "rxjs/add/operator/do";
import "rxjs/add/observable/throw";
import "rxjs/add/operator/map";


@Component({
  selector: 'app-dashboard',
  templateUrl: 'dashboard.component.html',
  styleUrls: ['dashboard.component.css']
})
export class DashboardComponent {
  title = 'Dashboard';
  email:string = "brijeshyadav152@gmail.com";
  password:string;
  loginFormGroup :FormGroup;
  user:any;

  constructor(private _http: Http){
    this.loginFormGroup = new FormGroup({
      email: new FormControl(),
      password:new FormControl()
   }); 
   this.GetUser();    
  }
    GetUser(){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser"; 
        let options = new RequestOptions();
        let result = this._http.post(APIURL, JSON.stringify({"email": this.email}),options).subscribe(res => console.log(res));
    } 
}

