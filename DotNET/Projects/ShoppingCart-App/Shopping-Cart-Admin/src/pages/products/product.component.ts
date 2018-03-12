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
  constructor(private _http: Http){    
  }

  ngOnInit(){
      //this.getProducts();
  }

  getProducts(){
    let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/Product/GetProducts";
    this._http.get(APIURL)
    .do((response) => { return response; })
    .map(res => res.json())
    .subscribe(products => this.productList = JSON.stringify(products));    
  }

    loginUser(){      
      console.log("into login user");
      let result :any;      
      let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/CheckLogin"; 

      result = this._http.post(APIURL,{
      })
      .subscribe(res=>{
        console.log(res)});

      console.log(result);
    } 
}

