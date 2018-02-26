import { Component } from "@angular/core";

@Component({templateUrl:'MasterChildComponent.html',selector:'ht-master'})
export class MasterChildComponent
{
constructor(){    
}

stateChanged(e){
    console.log(e);
}
starClicks(e){
    console.log(e);
}
}