import { Component } from '@angular/core';
import { Http, RequestOptions } from '@angular/http';
import {Observable} from 'rxjs/Observable';
import { NgModel, FormGroup, FormControl,ReactiveFormsModule  } from '@angular/forms';
import { EmailValidator } from '@angular/forms';
import "rxjs/add/operator/catch";
import "rxjs/add/operator/do";
import "rxjs/add/observable/throw";
import "rxjs/add/operator/map";
import { ActivatedRoute, Router } from '@angular/router';
import { UUID } from 'angular2-uuid';


@Component({
  selector: 'app-product',
  templateUrl: 'productCategoryDetails.component.html',
  styleUrls: ['productCategoryDetails.component.css']
})
export class ProductCategoryDetailComponent {
  title = 'Product Detail';
  email:string = localStorage.getItem("userEmail");
  productDetailFormGroup :FormGroup;
  user:any;
  product:any;
  productId :any;
  url:any;
  Name:string;
  ProductCategory:any;
  Details:any;
  Date:any;
  ProductImage:any;
  ADDAPIURL:any;
  constructor(private _http: Http,private route: ActivatedRoute,private router: Router){    
    this.productDetailFormGroup = new FormGroup({
      title: new FormControl(),
      description:new FormControl()
   });
  }

  ngOnInit() {
    if(this.email == null || this.email == "null"){
      this.router.navigate(['../Login'])
    }
    this.productId =this.route.snapshot.params['Id'] != null ? this.GetProductCategory(): UUID.UUID();
    this.GetUser();
  }
    GetUser(){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser?email="+this.email+""; 
        let result = this._http.get(APIURL).subscribe(res => {this.user =JSON.parse(res._body);});
    }
    
    GetProductCategory(){
    this.productId =this.route.snapshot.params['Id'] != null ? this.route.snapshot.params['Id']: UUID.UUID();
      let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/ProductCategory/GetProductCategory/"+this.productId+""; 
      console.log(APIURL);
      this.ADDAPIURL = this.ADDAPIURL != null ? this.ADDAPIURL :"http://localhost:56269//api/v1/ShoppingCart/ProductCategory/UpdateProductCategory";
      this._http.get(APIURL).subscribe(res => {
                                                console.log(res._body);
                                                this.ProductCategory =JSON.parse(res._body);
                                                this.Name = this.ProductCategory.Name;
                                                this.Date = this.ProductCategory.CreatedDate;
                                                console.log(this.ProductCategory)
                                            });
  }

    addProduct(){            
      let options = new RequestOptions();
      this.ADDAPIURL = this.ADDAPIURL != null ? this.ADDAPIURL :"http://localhost:56269//api/v1/ShoppingCart/ProductCategory/AddProductCategory";
      this.productId =this.route.snapshot.params['Id'] != null ? this.route.snapshot.params['Id']: UUID.UUID();
      this.product ={
        "Id":this.productId,
        "Name": this.Name,
        "Date" : this.Date
      }
      console.log(this.ADDAPIURL);
      console.log(this.product);
    //   this._http.post(this.ADDAPIURL,this.product,options)
    //   .subscribe(res=>{ 
    //   alert("Product Category Added Successfully");
    //   this.router.navigate(['../ProductCategories']);});
    }
}

