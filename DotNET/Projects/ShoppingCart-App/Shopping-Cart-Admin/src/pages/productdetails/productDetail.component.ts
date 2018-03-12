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
  templateUrl: 'productDetail.component.html',
  styleUrls: ['productDetail.component.css']
})
export class ProductDetailComponent {
  title = 'Product Detail';
  productList:any;
  email:string = localStorage.getItem("userEmail");
  password:string;
  productDetailFormGroup :FormGroup;
  user:any;
  product:any;
  productId :any;
  url:any;
  productCategories:any;
  Name:string;
  Price:string;
  ProductCategory:any;
  Details:any;
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
    this.productId =this.route.snapshot.params['ProductId'] != null ? this.GetProduct(): UUID.UUID();
    this.GetUser();
    this.GetProductCategories();
  }
    GetUser(){
        let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUser?email="+this.email+""; 
        let result = this._http.get(APIURL).subscribe(res => {this.user =JSON.parse(res._body);});
    }
    
    GetProductCategories(){
      let APIURL  = "http://localhost:56269//api/v1/ShoppingCart/ProductCategory/GetProductCategories"; 
      this._http.get(APIURL).subscribe(res => {this.productCategories =JSON.parse(res._body); console.log(this.productCategories)});
  }

  GetProduct(){
    this.ADDAPIURL  = "http://localhost:56269//api/v1/ShoppingCart/Product/UpdateProduct"; 
    this.productId = this.route.snapshot.params['ProductId'];
    console.log(this.productId);
    let APIURL  = "http://localhost:56269//api/v1/ShoppingCart/Product/GetProduct/"+this.productId+""; 
    this._http.get(APIURL).subscribe(res => {
                this.product =JSON.parse(res._body); 
                this.url = this.product.ProductImage;
                this.Name = this.product.Name;
                this.Price = this.product.Price;
                this.Details = this.product.Details;
                this.ProductCategory =this.product.ProductCategory;
              });
}

  readImageUrl(event:any) {
    if (event.target.files && event.target.files[0]) {
        var reader = new FileReader();
        reader.onload = (event:any) => {
          this.url = event.target.result;
        }
      reader.readAsDataURL(event.target.files[0]);
      }
    }

    addProduct(){            
      let options = new RequestOptions();
      this.ADDAPIURL = this.ADDAPIURL != null ? this.ADDAPIURL :"http://localhost:56269//api/v1/ShoppingCart/Product/AddProduct";
      this.productId =this.route.snapshot.params['ProductId'] != null ? this.route.snapshot.params['ProductId']: UUID.UUID();
      this.product ={
        "Id":this.productId,
        "Name": this.Name,
        "Price" :this.Price,
        "ProductImage":this.url,
        "ProductCategory":this.ProductCategory,
        "Details" : this.Details
      }
      this._http.post(this.ADDAPIURL,this.product,options)
      .subscribe(res=>{ 
      alert("Product Added Successfully");
      this.router.navigate(['../Products']);});
    }
}

