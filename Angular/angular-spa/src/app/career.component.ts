import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({templateUrl:'CareerComponent.html',selector:'ht-career'})
export class CareerComponent implements OnInit{
    careerId:any ;
    constructor(private route:ActivatedRoute){}
    ngOnInit(){
        this.careerId =this.route.snapshot.params['id'];
    }
};