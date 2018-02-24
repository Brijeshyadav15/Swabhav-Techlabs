import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';


import {WelcomeComponent} from '../Welcome/WelcomeComponent';
import {StudentComponent} from '../Student/StudentComponent';
import {BlueBoxComponent} from '../BlueBox/BlueBoxComponent';
import {TwoWayComponent} from '../TwoWay/TwoWayComponent';
import {BindingComponent} from '../Binding/BindingComponent';
import {MathService} from '../MathService/MathService';
import {NumberAPI} from '../MathService/NumberApiService';
import {HttpModule} from '@angular/http';

@NgModule({
  declarations: [
    WelcomeComponent,
    StudentComponent,
    BlueBoxComponent,
    TwoWayComponent,
    BindingComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [MathService,NumberAPI],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
