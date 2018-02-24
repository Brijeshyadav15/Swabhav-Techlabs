import { Component } from "@angular/core";

@Component({templateUrl:'BindingComponent.html',selector:'ht-binding'})
export class BindingComponent
{
message:string;
HTMLcolors=[];
fontsizes =[];
selectedSize:string;
constructor(){
    this.message = "Binding";
    this.HTMLcolors.push('Red','Green','Blue','Yellow');
    this.fontsizes.push('10px','15px', '25px', '20px');
}

    selectedBackColor()
    {
        console.log("Inside Selected Back");
    }

    selectedFontColor()
    {
        console.log("Inside Selected Font");
    }

}