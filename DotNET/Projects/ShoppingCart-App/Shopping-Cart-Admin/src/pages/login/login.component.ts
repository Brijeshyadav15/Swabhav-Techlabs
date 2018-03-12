import { ActivatedRoute, Router } from '@angular/router';
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

  constructor(private _http: Http,private router:Router){
    this.loginFormGroup = new FormGroup({
      email: new FormControl(),
      password:new FormControl()
   });     
  }
  
  ngOnInit() {      
      if(localStorage.getItem("userEmail") != "null"){
        this.router.navigate(['../Dashboard']);
      }
  }  

    loginUser(){      
      let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/CheckLogin"; 

      this._http.post(APIURL,{"Email" : this.email,"Password" : this.password},new RequestOptions())
      .subscribe(res=>{
        if(res.ok == true){
          localStorage.setItem("userEmail", this.email);
          this.router.navigate(['../Dashboard'])
        }
        else{
          alert('Login Unsuccessful');
        } 
      });
    } 
}

