import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import {WelcomeComponent} from '../Welcome/WelcomeComponent';
import {StudentComponent} from '../Student/StudentComponent';
import {BlueBoxComponent} from '../BlueBox/BlueBoxComponent';
import {TwoWayComponent} from '../TwoWay/TwoWayComponent';
import {BindingComponent} from '../Binding/BindingComponent';
import {MathService} from '../Services/MathService';
import {NumberAPI} from '../Services/NumberApiService';
import {HttpModule} from '@angular/http';
import {QuestionBank} from '../Services/QuestionBankService';
import {QuestionBankComponent} from '../QuestionBank/QuestionBankComponent';
import {MasterChildComponent} from '../MasterChildComponent/MasterChildComponent';
import {ToggleButtonComponent} from '../MasterChildComponent/ToggleButtonComponent';
import {StarComponent} from '../MasterChildComponent/StarComponent';
import {SummaryComponent} from '../SummaryPipe/SummaryComponent';
import { SummaryPipe } from '../SummaryPipe/Summary.pipe';


@NgModule({
  declarations: [
    WelcomeComponent,
    StudentComponent,
    BlueBoxComponent,
    TwoWayComponent,
    BindingComponent,
    QuestionBankComponent,
    MasterChildComponent,
    ToggleButtonComponent,
    StarComponent,
    SummaryComponent,
    SummaryPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [MathService,NumberAPI,QuestionBank],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
