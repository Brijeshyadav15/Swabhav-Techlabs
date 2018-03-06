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
    this.expenses = this.service.getExpenses();
  }
  
  onSelectExpense(e){
    let res = this.service.getExpensesById(e);
    console.log(res);
    this.navCtrl.push(ExpenseDetail,res);
  }

  onSelectAdd(){
    let res ={"id":0,"cost":0,"description":"","category":"","date":""}
    this.navCtrl.push(ExpenseDetail,JSON.stringify(res));
  }
}
