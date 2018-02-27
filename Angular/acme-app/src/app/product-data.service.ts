import { Http } from '@angular/http';
import { Injectable } from "@angular/core";
import { reject } from "q";
import {Observable} from 'rxjs/Observable';
import "rxjs/add/operator/catch";
import "rxjs/add/operator/do";
import "rxjs/add/observable/throw";
import "rxjs/add/operator/map";

@Injectable()
export class ProductDataService{
    products:any;
    DATAURL = 'http://localhost:4200/assets/products.json'
    constructor(private _http : Http){
    }
    getProducts(): Observable<any> {
        console.log(this.DATAURL);
        return this._http.get(this.DATAURL)
        .do((response) => { return response; })
        .map(res => res.json());        
    }

    getProductsById(id):Observable<any>{
        if(id > 0){
          this.getProducts()
          .subscribe(products => this.products = products);
          console.log(this.products);
        }
        return null;
    }
}