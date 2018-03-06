import { ExpenseList } from './../expenseList/expenselist';
import { AuthenicationService } from './../../app/authenicationService';
import { Component } from '@angular/core';
import { NavController} from 'ionic-angular';
import { FormGroup,FormControl } from '@angular/forms';
import { AlertController } from 'ionic-angular';

@Component({
  selector: 'page-authenication',
  templateUrl: 'authenication.html'
})
export class Authenication {
  user ={
    "username":'',
    "password":''
  }
  loginGroup :FormGroup;  
  constructor(public navCtrl: NavController,private service:AuthenicationService, private alertCtrl:AlertController){ 
    this.loginGroup = new FormGroup({
        username: new FormControl(),
        password: new FormControl()
     });
  }

  ngOnInit() {    
  }

  login(){
      let result = this.service.checkLogin(this.user);
      let alert = this.alertCtrl.create({
        buttons: [
          {
            text: 'OK',
          }
        ]
      });  
      
      if(result){
        alert.setMessage("Login Successful");
        alert.present();
        this.navCtrl.setRoot(ExpenseList);
      }
      else{
        alert.setMessage("Login Failed. Try AGAIN!!");
        alert.present();
      }
  }

}
