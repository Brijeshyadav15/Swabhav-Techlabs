import { NavParams } from 'ionic-angular';
import { Component } from '@angular/core';

import { NotesList } from './../notesList/notesList';
import { NotesDetail } from './../notesDetail/notesDetail';

@Component({
  templateUrl: 'tabs.html'
})
export class TabsPage {

  tab1Root = NotesList;
  tab2Root = NotesDetail;

  constructor(params: NavParams) {
    console.log(JSON.stringify(params));

  }
}
