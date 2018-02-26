import { QuestionBank } from './../Services/QuestionBankService';
import { Component } from "@angular/core";

@Component({templateUrl:'QuestionBankComponent.html',selector:'ht-questionBank'})
export class QuestionBankComponent
{
message:string;
questions:any;
options:any;
constructor(private _qb : QuestionBank){
    this.message = "Question Bank App";
    this.questions  =  _qb.initializeQuestions();
    console.log(this.questions);

    this.options  =  _qb.getOptions();
    console.log(this.options);
}
}