import { Component, OnInit ,Input, Output , EventEmitter} from "@angular/core";

@Component({templateUrl:'StarComponent.html',selector:'ht-star'})
export class StarComponent 
{

    @Input() rating= 3;
    @Output() starClicks : EventEmitter<String> = new  EventEmitter<String>();
    ngOnInit(): void {
    }

    starClicked(e){
        this.starClicks.emit(this.rating.toString());
    }
}