import { AppComponent } from './app.component';
import { NgModule } from '@angular/core';
import { routeArray } from './RouteConfig';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { NotFoundComponent } from './notfound.component';
import { EditComponent } from './edit.component';
import { AddComponent } from './add.component';
import { HomeComponent } from './home.component';

import { StudentService } from './studentsService';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AddComponent,
    EditComponent,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot(routeArray)
  ],
  providers: [StudentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
