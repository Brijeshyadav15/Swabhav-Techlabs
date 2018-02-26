import { Component, OnInit ,Input, Output , EventEmitter} from "@angular/core";

@Component({templateUrl:'ToggleButtonComponent.html',selector:'ht-toggle-btn'})
export class ToggleButtonComponent implements OnInit
{
    @Input() textContext : String;
    @Output() stateChanged : EventEmitter<String> = new  EventEmitter<String>();
    @Input() backColor : String ="Yellow";
    @Input() onColor : String;
    @Input() offColor : String;
    state: String = "Off";

    ngOnInit(): void {
        console.log("Inside Init");
        console.log(this.textContext);
        //this.textContext ="Nothing";
    }
    constructor(){    
        //console.log("Inside Constructor");
    }

    onClickHandler(){
        if(this.state == "Off")
        {
            this.stateChanged.emit("Off");
            this.backColor = this.offColor;
            this.state = "On"
        }
        else if(this.state == "On")
        {
            this.stateChanged.emit("On");
            this.backColor = this.onColor;
            this.state = "Off"
        }
    }

}