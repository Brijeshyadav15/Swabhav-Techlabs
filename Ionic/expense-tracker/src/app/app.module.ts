import { ExpenseDetail } from './../pages/expenseDetail/expenseDetail';
import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { ExpenseTracker } from './expenseTracker.service';
import { ExpenseList } from '../pages/expenseList/expenselist';

@NgModule({
  declarations: [
    MyApp,
    ExpenseList,
    ExpenseDetail
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    ExpenseList,
    ExpenseDetail
  ],
  providers: [
    StatusBar,
    SplashScreen,
    {provide: ErrorHandler, useClass: IonicErrorHandler},
    ExpenseTracker
  ]
})
export class AppModule {}
