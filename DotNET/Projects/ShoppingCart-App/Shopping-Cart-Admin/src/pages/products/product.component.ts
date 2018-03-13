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
  selector: 'app-products',
  templateUrl: 'product.component.html',
  styleUrls: ['product.component.css']
})
export class ProductComponent {
  title = 'Product List';
  productList:any;
  email:string = localStorage.getItem("userEmail");
  password:string;
  loginFormGroup :FormGroup;
  user:any;
  products:any;

  constructor(private _http: Http,private router:Router){    
  }

  ngOnInit() {
    if(this.email == null || this.email == "null"){
      this.router.navigate(['../Login'])
    }
    this.GetUser();
    this.GetProducts();
  }
    GetUser(){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser?email="+this.email+""; 
        let result = this._http.get(APIURL).subscribe(res => {this.user =JSON.parse(res._body);});
    } 

    GetProducts(){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/Product/GetProducts"; 
        this._http.get(APIURL).subscribe(res => {this.products =JSON.parse(res._body); console.log(this.products)});
    }

    DeleteProduct(Id){
      let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/Product/DeleteProduct/"+Id+""; 
      this._http.get(APIURL).subscribe(res => {
        if(res.ok== true){
          console.log("Product Deleted Successfully");
          this.ngOnInit();
      }
    });
    }   
}