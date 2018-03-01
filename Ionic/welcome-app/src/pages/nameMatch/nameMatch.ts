import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';
import { Contact, ContactField, ContactName, Contacts } from '@ionic-native/contacts';

@Component({
  selector: 'name-match',
  templateUrl: 'nameMatchComponent.html'
})
export class NameMatch {
  result:any;
  name1:string;
  name2:string;
  contactList:any;
  constructor(public navCtrl: NavController,private contacts: Contacts) {
  }

  fetchContact1(){
    this.contacts.pickContact().then((contacts) => {
    this.name1 = contacts.displayName;
    this.calculateResult();
  });
  }

  fetchContact2(){
    this.contacts.pickContact().then((contacts) => {
    this.name2= contacts.displayName;
    this.calculateResult();
  });
  }

  calculateResult(){
    let sum :number =0;
    this.name1 = this.name1 != null ?this.name1.toUpperCase() : '';
    this.name2 = this.name2 != null? this.name2.toUpperCase() : '';    
    for (let i = 0; i < this.name1.length; i++) {
      sum += this.name1.charCodeAt(i);
    }

    for (let i = 0; i < this.name2.length; i++) {
      sum += this.name2.charCodeAt(i);      
    }
    console.log(sum);
    this.result=sum % 101 +'%'; 
    console.log(this.result);
  }
}


