import { Router } from '@angular/router';
import { Component } from '@angular/core';
import { Http, RequestOptions } from '@angular/http';
import {Observable} from 'rxjs/Observable';
import { NgModel, FormGroup, FormControl,ReactiveFormsModule  } from '@angular/forms';
import { EmailValidator } from '@angular/forms';
import { DatePipe } from '@angular/common';
import "rxjs/add/operator/catch";
import "rxjs/add/operator/do";
import "rxjs/add/observable/throw";
import "rxjs/add/operator/map";


@Component({
  selector: 'app-orders',
  templateUrl: 'orders.component.html',
  styleUrls: ['orders.component.css']
})
export class OrdersComponent {
  title = 'Orders';
  email:string = localStorage.getItem("userEmail");
  password:string;
  loginFormGroup :FormGroup;
  user:any;
  orders:any;

  constructor(private _http: Http,private router:Router){   
  }

  ngOnInit() {
    if(this.email == null || this.email == "null"){
      this.router.navigate(['../Login'])
    }
    this.GetUser();
    this.GetOrders();
  }
    GetUser(){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser?email="+this.email+""; 
        let result = this._http.get(APIURL).subscribe(res => {this.user =JSON.parse(res._body);});
    } 

    GetOrders(){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/00000000-0000-0000-0000-000000000000/Order/GetOrders"; 
        this._http.get(APIURL).subscribe(res => {
                                                this.orders =JSON.parse(res._body);
                                                console.log(this.orders);
                                                this.GetCustomerDetails();
                                                });
    }    

    GetCustomerDetails(){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser/BC066F3C-9DF3-1FBF-AF6B-C522A05C1501"; 
        this._http.get(APIURL).subscribe(res => {console.log(res)});

    }
}

