import { UUID } from 'angular2-uuid';
import { ExpenseTracker } from './../../app/expenseTracker.service';

import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { AlertController } from 'ionic-angular';

@Component({
  selector: 'page-expenseDetail',
  templateUrl: 'expenseDetail.html'
})
export class ExpenseDetail {
  expense:any;
  categories:any;  
  constructor(public navCtrl: NavController,private service:ExpenseTracker, private navParams: NavParams,private alertCtrl: AlertController){ 
  }

  ngOnInit() {    
    this.categories = this.service.getCategories();    
    this.expense = Object.assign(JSON.parse(this.navParams.data));
    if(this.expense.id == 0){
      this.expense.id =UUID.UUID();
    }

    if(this.expense.date.length > 3)
      this.expense.date = new Date(this.expense.date).toISOString();  
    else if(this.expense.date.length == 0)
      this.expense.date = new Date().toISOString(); 

  }
  
  deleteItem(id){
    let alert = this.alertCtrl.create({
      title: 'Delete Expense',
      message: 'Do you want to Delete this Expense?',
      buttons: [
        {
          text: 'Cancel',
          role: 'cancel',
          handler: () => {
            //this.navCtrl.pop();
          }
        },
        {
          text: 'Delete',
          handler: () => {
            this.service.deleteExpense(id);
            this.navCtrl.pop();
          }
        }
      ]
    });  
    alert.present();
  }

  submitChanges(){
    console.log(this.expense);
    this.service.updateExpense(this.expense);    
    this.navCtrl.pop();
  }

  cancelChanges(){
    this.navCtrl.pop();
  }
}
