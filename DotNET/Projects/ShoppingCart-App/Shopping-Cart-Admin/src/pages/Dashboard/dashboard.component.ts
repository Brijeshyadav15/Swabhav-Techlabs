import { Router } from '@angular/router';
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
  email:string = localStorage.getItem("userEmail");
  loginFormGroup :FormGroup;
  user:any;
  userCount:number;
  productCount:number;
  productCategoriesCount:number;
  orderCount:number;
  loadingView:boolean = true;
  constructor(private _http: Http,private router:Router){   
  }

  ngOnInit() {
    if(this.email == null || this.email == "null"){
      this.router.navigate(['../Login'])
    }
    this.GetUser();
    this.GetUserCount();
    this.GetOrdersCount();
    this.GetProductCount();
    this.GetProductCategoriesCount();
  }
  ngAfterViewInit() {
    this.loadingView = false;
  }

    GetUser(){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser?email="+this.email+""; 
        let result = this._http.get(APIURL).subscribe(res => {this.user =JSON.parse(res._body);});
    } 

    GetUserCount(){
      let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUserCount"; 
      let result = this._http.get(APIURL).subscribe(res => {this.userCount =JSON.parse(res._body);});
    } 

    GetProductCount(){
      let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/Product/GetProductCount"; 
      let result = this._http.get(APIURL).subscribe(res => {this.productCount =JSON.parse(res._body);});
    } 

    GetProductCategoriesCount(){
      let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/ProductCategory/GetProductCategoryCount"; 
      let result = this._http.get(APIURL).subscribe(res => {this.productCategoriesCount =JSON.parse(res._body);});
    }

    GetOrdersCount(){
      let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/00000000-0000-0000-0000-000000000000/Order/GetOrderCount"; 
      let result = this._http.get(APIURL).subscribe(res => {this.orderCount =JSON.parse(res._body);});
    }
}