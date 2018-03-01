import { Component } from "@angular/core";
import { Router, ActivatedRoute } from '@angular/router';

import { ProductDataService } from './product-data.service';
import { IProduct } from './IProduct';

@Component({templateUrl:'ProductDetail.html',selector:'ht-detail'})
export class ProductDetailComponent{
    product:IProduct;    
    id:number;
    constructor(private _dataservice: ProductDataService,private route:ActivatedRoute){
    }

    stateChanged(e){
        console.log(e);
    }
    
    ngOnInit(): void {
        this.id =this.route.snapshot.params['ProductId'];        
        
        this._dataservice.getProductsById(this.id).
        subscribe(products => {
            this.product = products;
          });    
      }
    
      back(){
        window.history.back();
      }
};