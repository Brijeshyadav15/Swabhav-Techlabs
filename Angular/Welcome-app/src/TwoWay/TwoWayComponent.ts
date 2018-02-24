import { Response } from '@angular/http';
import { NumberAPI } from './../MathService/NumberApiService';
import { MathService } from './../MathService/MathService';
import { Component } from "@angular/core";


@Component({templateUrl:'TwoWayComponent.html',selector:'ht-twoway'})
export class TwoWayComponent{
    result;    
    NumberInput:any;
    backColor ='Yellow';
    names = [];
    facts:string = null;
    firstName:string;
    lastName:string;
    selectedName: string;
    constructor(private _svc:MathService, private _apisvc: NumberAPI){       
    this.names.push('HiTech','Swabhav','Google','Amazon');
    this.firstName = 'Brijesh';
    this.lastName ='Yadav';
    }    

    firstNameChanged(newName)
    {    
    this.firstName =newName;
    }

    checkNumber(no)
    {
        no = no.target.value;
        this._svc.checkIsPrime(no).
        then((r)=>{ 
            console.log(r);
            if(r == 1){
             this.result= 'True';
             this.backColor ='Green'
            }
            else if(r == 0){
                this.result = 'False';
                this.backColor ='Red'
            }
         });
    }

    getData(no)
    {
        
        let res=this._apisvc.getDatafromNumbersAPI(no)
        .then((Response)=>{ 
            if(no != null && no > 0)
        {
            console.log(Response._body);
            this.facts = Response._body;
            this.backColor = 'Green';
        }
         })
         .catch(() =>{
             this.backColor = 'Red';
             this.facts = "Enter Proper Number";
            });
    }
}