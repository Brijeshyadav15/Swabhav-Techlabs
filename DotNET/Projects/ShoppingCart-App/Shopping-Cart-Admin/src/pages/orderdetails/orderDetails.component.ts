import { UUID } from 'angular2-uuid';
import { Router, ActivatedRoute } from '@angular/router';
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
  selector: 'app-orderDetails',
  templateUrl: 'orderDetails.component.html',
  styleUrls: ['orderDetails.component.css']
})
export class OrderDetailsComponent {
  title = 'Order Detail';
  email:string = localStorage.getItem("userEmail");
  password:string;
  loginFormGroup :FormGroup;
  user:any;
  order:any;
  orderId:any;
  OrderStatus:any;
  Date:any;
  Name:any;
  OrderStatusOptions =['ORDERED','CONFIRMED','INTRANSIT','DELIVERED'];
  customer:any;
  constructor(private _http: Http,private router:Router,private route :ActivatedRoute){   
    this.GetUser();
  }

  ngOnInit() {
    if(this.email == null || this.email == "null" || this.route.snapshot.params['Id'] == null){
      this.router.navigate(['../Login'])
    }
    this.orderId =this.route.snapshot.params['Id'] != null ? this.GetOrder(): UUID.UUID();
  }
    GetUser(){
        console.log("Into GetUser");
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser?email="+this.email+""; 
        let result = this._http.get(APIURL).subscribe(res => {
                                                              console.log(res);
                                                              this.user =JSON.parse(res._body);
                                                            });
    } 

    GetOrder(){
        this.orderId =this.route.snapshot.params['Id'];
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/00000000-0000-0000-0000-000000000000/Order/GetOrder/"+ this.orderId+""; 
        this._http.get(APIURL).subscribe(res => {
                                                this.order =JSON.parse(res._body);
                                                console.log(this.order);
                                                this.GetCustomerDetails(this.order.CustomerId);
                                                });
    }    

    GetCustomerDetails(CustomerID){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser/"+CustomerID+""; 
        this._http.get(APIURL).subscribe(res => {
                                                this.customer = JSON.parse(res._body);
                                                });
    }
}

