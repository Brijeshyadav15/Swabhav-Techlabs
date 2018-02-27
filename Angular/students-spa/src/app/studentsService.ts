import { Http } from '@angular/http';
import { Injectable } from "@angular/core";
import { reject } from "q";
import { IStudent } from './IStudent';
import {Observable} from 'rxjs/Observable';
import "rxjs/add/operator/catch";
import "rxjs/add/operator/do";
import "rxjs/add/observable/throw";
import "rxjs/add/operator/map";


@Injectable()
export class StudentService{
    APIURL:any;
    students:IStudent;
    constructor(private _http: Http){        
        this.APIURL= "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/";
    }

    getData() :Observable<IStudent>{        
        return this._http.get(this.APIURL)
        .do((response) => { return response; })
        .map(res => <IStudent>res.json())
    }

    getDataById(id) :Observable<IStudent> {
        return this._http.get(this.APIURL+id)
        .do((response) => { return response; })
        .map(res => <IStudent>res.json())
    }

    deleteStudent(id){
        return this._http
        .delete(this.APIURL+id)
        .toPromise();
    }

    addStudent(IStudent){
        return this._http
        .post(this.APIURL,IStudent)
        .toPromise();
    }

    updateStudent(IStudent, id){
        return this._http
        .put(this.APIURL + id ,IStudent)
        .toPromise();
    }
}