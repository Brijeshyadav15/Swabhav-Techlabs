import { Component } from "@angular/core";

import { ProductDataService } from "./product-data.service";

import "rxjs/add/operator/filter";

import { IProduct } from './IProduct';
@Component({templateUrl:'ProductList.html',selector:'ht-list'})
export class ProductListComponent{
    products:IProduct;    
    showImages: boolean = false;
    filterString:string;
    constructor(private _dataservice: ProductDataService){
    }

    stateChanged(e){
        console.log(e);
    }
    ngOnInit(): void {
        this._dataservice.getProducts()
          .subscribe(products => {
              this.products = products;
            });
    }
    
    showImage(){
        this.showImages = !this.showImages;
    }

    productfilter(e){
        this.filterString = e;
        this._dataservice.getFilteredProducts(e)
            .subscribe(products => {
                this.products = products;
              });
    }
};