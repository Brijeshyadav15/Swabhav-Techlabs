import { Http } from '@angular/http';
import { Router } from '@angular/router';
import { Component } from '@angular/core';
import { NgModel, FormGroup, FormControl,ReactiveFormsModule  } from '@angular/forms';

@Component({
  selector: 'app-sidebar',
  templateUrl: 'sidebar.component.html',
  styleUrls: ['sidebar.component.css']
})
export class SidebarComponent {
  email:string = localStorage.getItem("userEmail");
  user:any;
  
  constructor(private _http:Http){   
  }

  ngOnInit() {
    this.GetUser();
  }
  
  GetUser(){
    let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser?email="+this.email+""; 
    let result = this._http.get(APIURL).subscribe(res => {this.user =JSON.parse(res._body);});
  }
}