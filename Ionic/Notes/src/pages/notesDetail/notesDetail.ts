import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { FormGroup,FormControl } from '@angular/forms';
import { UUID } from 'angular2-uuid';

import { NotesService } from './../../app/notesService';


@Component({
  selector: 'notes-Detail',
  templateUrl: 'notesDetail.html'
})
export class NotesDetail {
    note:any;
    noteFormGroup :FormGroup;
  constructor(public navCtrl: NavController,public service:NotesService,private navParams: NavParams) {
      this.noteFormGroup = new FormGroup({
        title: new FormControl(),
        description:new FormControl()
     });
  }

ngOnInit() {            
        this.note =this.navParams.data.length > 3? Object.assign(JSON.parse(this.navParams.data)) : {"id":"" , "title": "", "description": "", "date": ""};  
}
addNote(){
    this.note.id = this.note.id.length > 4 ? this.note.id:UUID.UUID();  
    this.note.date = new Date().toISOString();    
    this.service.updateNote(this.note);
    this.note={"id":"" , "title": "", "description": "", "date": ""};
    this.navCtrl.parent.select(0); 
}

}
