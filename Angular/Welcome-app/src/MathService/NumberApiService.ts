import { Http } from '@angular/http';
import { Injectable } from "@angular/core";
import { reject } from "q";

@Injectable()
export class NumberAPI{
    constructor(private _http: Http){        
    }

    getDatafromNumbersAPI(no)
    {
       console.log("http://numbersapi.com/"+no);
       return  this._http
                   .get("http://numbersapi.com/"+no)
                   .toPromise();
    }
}