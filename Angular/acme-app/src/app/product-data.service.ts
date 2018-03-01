import { Http } from '@angular/http';
import { Injectable } from "@angular/core";
import { reject } from "q";
import {Observable} from 'rxjs/Observable';

import "rxjs/add/operator/catch";
import "rxjs/add/operator/do";
import "rxjs/add/observable/throw";
import "rxjs/add/operator/map";
import "rxjs/add/operator/filter";

import { IProduct } from './IProduct';
@Injectable()
export class ProductDataService{
    products:IProduct;
    DATAURL = 'http://localhost:4200/assets/products.json'
    constructor(private _http : Http){
    }
    getProducts(): Observable<IProduct> {
        return this._http.get(this.DATAURL)
        .do((response) => { return response; })
        .map(res => <IProduct>res.json());        
    }

    getProductsById(id):Observable<IProduct>{
        if(id > 0){ 
                return this._http.get(this.DATAURL)
                    .do((response) => { return response;})
                    .map(res => {
                        let filterdata = res.json().filter(product => product.productId == id);
                        return (filterdata.length > 0) ? filterdata[0] : null;
                    })
        }
        else if(id ==0){
            return null;        
        }
    }   

    getFilteredProducts(name):Observable<IProduct>{
        name = name.toLocaleLowerCase();
        return this._http.get(this.DATAURL)
                    .do((response) => { return response;})
                    .map(res => {
                        let filterdata = res.json().filter(product => product.productName.toLocaleLowerCase().indexOf(name) !== -1);
                        console.log(filterdata);
                        return (filterdata.length > 0) ? filterdata : null;
                    })
    }
}