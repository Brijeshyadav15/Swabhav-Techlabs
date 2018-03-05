import { Injectable } from "@angular/core";

@Injectable()
export class NotesService{
    vardate:any;
    notes:any;

    constructor(){
    }
    
    getNotes(){
        this.notes =JSON.parse(localStorage.getItem('notes')) != null  ?JSON.parse(localStorage.getItem('notes')) : [''];
        return this.notes;
    }

    getNoteById(id){
        for(let note of this.notes){
            if(note.id == id)
                return JSON.stringify(note)
        }
    }

    addNote(note){
        this.notes.push(note);
        this.saveNotes();
    }

    saveNotes(){
        localStorage.setItem("notes",JSON.stringify(this.notes));
    }

    reorderList(notes){
        this.notes = notes;
        this.saveNotes();
    }

    deleteNote(id){
        let note:any;
        for(let n of this.notes){
            if(n.id ==id){
                note = n;
            }
        }
        let val = this.notes.indexOf(note);
        if(val >-1){
            this.notes.splice(val,1);
        }        
        this.saveNotes();
    }

    updateNote(notetobeAdded){
        let noteRemoved :any
        
        for(let note of this.notes){
            if(note.id == notetobeAdded.id){
                noteRemoved = note;
            }
        }

        let val = this.notes.indexOf(noteRemoved);
        if(val >-1){
            this.notes.splice(val,1);
        }        
        this.notes.push(notetobeAdded);
        this.saveNotes();
    }

}