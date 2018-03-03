import { ExpenseTracker } from './../../app/expenseTracker.service';

import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';

@Component({
  selector: 'page-expenseDetail',
  templateUrl: 'expenseDetail.html'
})
export class ExpenseDetail {
  expense:any;
  categories:any;
  constructor(public navCtrl: NavController,private service:ExpenseTracker, private navParams: NavParams) { 
  }

  ngOnInit() {   
    this.categories = JSON.parse(this.service.getCategories());    
    this.expense = Object.assign(JSON.parse(this.navParams.data));
  }
  
  deleteItem(id){
    this.service.deleteExpense(id);
    this.navCtrl.pop();
  }

  submitChanges(){
    this.service.updateExpense(this.expense);    
    this.navCtrl.pop();
  }

  cancelChanges(){
    this.navCtrl.pop();
  }
}
