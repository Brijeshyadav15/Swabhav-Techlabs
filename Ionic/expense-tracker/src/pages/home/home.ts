import { ExpenseTracker } from './../../app/expenseTracker.service';

import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  expenses:any;

  constructor(public navCtrl: NavController,private service:ExpenseTracker) { 
  }

  ngOnInit() {        
    this.expenses = JSON.parse(this.service.getExpenses());
    console.log(this.expenses);
  }
  
  onSelectExpense(e){
    console.log(e);
    alert(e);
  }
  
}
