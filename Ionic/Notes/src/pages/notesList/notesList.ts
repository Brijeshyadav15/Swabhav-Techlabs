import { Component } from '@angular/core';
import { NavController, AlertController } from 'ionic-angular';

import { NotesDetail } from './../notesDetail/notesDetail';
import { NotesService } from './../../app/notesService';

@Component({
  selector: 'notes-List',
  templateUrl: 'notesList.html'
})
export class NotesList {

notes:any=[];
reorder = false;
  constructor(public navCtrl: NavController,public service:NotesService,private alertCtrl: AlertController) {
  }
  
  ngOnInit() {        
    this.notes = this.service.getNotes();
  }  

  editNote(note){
      this.navCtrl.push(NotesDetail,JSON.stringify(note));
  }

  checkReorder(){
      this.reorder = this.reorder == false ? true :false;
  }

  reorderNotes(indexes){
    let element = this.notes[indexes.from];
    this.notes.splice(indexes.from, 1);
    this.notes.splice(indexes.to, 0, element);
    this.service.reorderList(this.notes);
  }

  deleteNote(note){
    let alert = this.alertCtrl.create({
        title: 'Delete Note',
        message: 'Do you want to Delete this Note?',
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
                this.service.deleteNote(note.id);
                //slidingItem.close();
            }
          }
        ]
      });  
      alert.present();
  }
}
