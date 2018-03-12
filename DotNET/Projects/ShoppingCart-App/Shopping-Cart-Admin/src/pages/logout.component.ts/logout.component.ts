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
  templateUrl: 'logout.component.html',
})
export class LogoutComponent {  
  constructor(private _http: Http,private router:Router){    
  }
  
  ngOnInit() {      
      if(localStorage.getItem("userEmail") == null){
        this.router.navigate(['../Login']);
      }
      this.logoutUser();
  }
  
  logoutUser(){
    localStorage.setItem("userEmail", null);
    this.router.navigate(['../Login']);
  }
}

