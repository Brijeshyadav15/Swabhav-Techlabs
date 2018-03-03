import { ExpenseTracker } from './../../app/expenseTracker.service';

import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { UUID } from 'angular2-uuid';


@Component({
  selector: 'page-expenseAdd',
  templateUrl: 'addExpense.html'
})
export class AddExpense {
  expense:any;
  categories:any;
  cost:number;
  description:any;
  date:any;
  name:any;
  id:any;
  constructor(public navCtrl: NavController,private service:ExpenseTracker, private navParams: NavParams) { 
  }

  ngOnInit() {   
    this.categories = this.service.getCategories();
  }
  
  deleteItem(){
    
    this.navCtrl.pop();
  }

  submitChanges(){
    this.service.updateExpense(this.expense);    
    this.navCtrl.pop();
  }

  cancelChanges(){
    this.navCtrl.pop();
  }

  addExpense(expense){
    this.expense ={
      "id" : UUID.UUID(),
      "cost":this.cost,
      "description":this.description,
      "category":this.name,
      "date":this.date
    };
    this.service.addExpense(expense);
    this.navCtrl.pop();
  }
}
