import { Component } from "@angular/core";
import { ProductDataService } from "./product-data.service";

@Component({templateUrl:'ProductList.html',selector:'ht-list'})
export class ProductListComponent{
    products:any;    
    showImages: boolean = false;
    constructor(private _dataservice: ProductDataService){
    }

    stateChanged(e){
        console.log(e);
    }
    ngOnInit(): void {
        this._dataservice.getProducts()
          .subscribe(products => this.products = products);
      }
    
      showImage(){
        this.showImages = !this.showImages;
      }
};