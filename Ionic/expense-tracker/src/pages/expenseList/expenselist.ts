import { ExpenseDetail } from './../expenseDetail/expenseDetail';
import { ExpenseTracker } from './../../app/expenseTracker.service';

import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-expense',
  templateUrl: 'expenselist.html'
})
export class ExpenseList {
  expenses:any;
  constructor(public navCtrl: NavController,private service:ExpenseTracker) { 
  }

  ngOnInit() {        
    this.expenses = JSON.parse(this.service.getExpenses());
    console.log(this.expenses);
  }
  
  onSelectExpense(e){
    let res = this.service.getExpensesById(e);
    console.log(res);
    this.navCtrl.push(ExpenseDetail,res);
  }
  
}
