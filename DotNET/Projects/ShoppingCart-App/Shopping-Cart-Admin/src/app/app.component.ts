import { Component } from '@angular/core';
import { Http } from '@angular/http';
import {Observable} from 'rxjs/Observable';
import "rxjs/add/operator/catch";
import "rxjs/add/operator/do";
import "rxjs/add/observable/throw";
import "rxjs/add/operator/map";


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  data:any;
  students:any;
  constructor(private _http: Http){     
  }

  getData(){       
    let APIURL  = "http://localhost:56269/api/v1/ShoppingCart/User/GetUsers";    
    return this._http.get(APIURL)
    .do((response) => { return response; })
    .map(res => res.json())
    .subscribe(students => this.students = JSON.stringify(students));    
  }
}

