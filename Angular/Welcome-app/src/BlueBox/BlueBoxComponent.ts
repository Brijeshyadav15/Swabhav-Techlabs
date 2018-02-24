import { Component } from "@angular/core";

@Component({templateUrl:'BlueBoxComponent.html',selector:'ht-bluebox'})
export class BlueBoxComponent{
    randomNumber = Math.round((Math.random() * 10) * 10);
    size = [];
    trialCounter =0;
    constructor(){
        console.log(this.randomNumber);
        for(let i=1;i< 100;i++){
        this.size.push(i);
        }
    }    
    
    checkResult(e)
      {
          var guessedNumber = e.target.id;
          if(this.trialCounter <3)
          {
              this.trialCounter++;
              if (guessedNumber == this.randomNumber) {
                console.log("Correct Number");
                e.target.classList.remove('blankbox');
                e.target.classList.add('bluebox');
                
            }
            else if (guessedNumber > this.randomNumber) {
                console.log("Greater Number");
                e.target.classList.remove('blankbox');
                e.target.classList.add('redbox');
            }
            else if  (guessedNumber < this.randomNumber) {
                e.target.classList.remove('blankbox');
                e.target.classList.add('greenbox');
            }
          }
          else {
            alert("Sorry You are out of  trails!! You Lost");
            location.reload();
        }       
      }
}