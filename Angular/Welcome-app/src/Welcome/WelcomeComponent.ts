import { Component } from "@angular/core";

@Component({templateUrl:'WelcomeComponent.html',selector:'ht-welcome'})
export class WelcomeComponent
{
message:string;
constructor(){
    this.message = "Welcome to Angular 5";
}
}