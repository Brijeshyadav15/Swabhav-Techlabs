import { ProductDataService } from './product-data.service';
import { Component } from "@angular/core";
import { Router, ActivatedRoute } from '@angular/router';


@Component({templateUrl:'ProductDetail.html',selector:'ht-detail'})
export class ProductDetailComponent{
    product:any;    
    id:number;
    constructor(private _dataservice: ProductDataService,private route:ActivatedRoute){
    }

    stateChanged(e){
        console.log(e);
    }
    ngOnInit(): void {
        this.id =this.route.snapshot.params['ProductId'];        
        this._dataservice.getProductsById(this.id);
      }
};