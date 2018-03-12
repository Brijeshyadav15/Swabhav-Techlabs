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
  selector: 'app-login',
  templateUrl: 'login.component.html',
  styleUrls: ['login.component.css']
})
export class LoginComponent {
  title = 'Shopping Cart Admin';
  email:string;
  password:string;
  loginFormGroup :FormGroup;
  constructor(private _http: Http){
    this.loginFormGroup = new FormGroup({
      email: new FormControl(),
      password:new FormControl()
   });     
  }
    loginUser(){      
      console.log("into login user");
      let result :any;      
      let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/CheckLogin"; 
      let options = new RequestOptions();
      console.log(APIURL);
      
      result = this._http.post(APIURL,{
        "email" : this.email,
        "password" : this.password
      },options)
      .subscribe(res=>{
        console.log(res);
      });

      // if(result == true){
      //   alert('Login Successful');
      // }
      // else{
      //     alert('Login Unsuccessful');
      // }
      // console.log(result);

        // if(result == true){
        //   alert('Login Successful');
        //   let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser?email="+this.email+""; 
        //   result  = this._http.get(APIURL)
        // .map(result=>result._body)
        // }
        // else{
        //   alert('Login Unsuccessful');
        // }
    } 
}

