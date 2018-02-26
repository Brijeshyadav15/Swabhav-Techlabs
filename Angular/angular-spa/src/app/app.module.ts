import { CareerComponent } from './career.component';
import { AboutComponent } from './about.component';
import { HomeComponent } from './home.component';
import { HttpModule } from '@angular/http';
import { BrowserModule} from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import {routeArray} from './RouteConfig';
import { NotFoundComponent } from './notfound.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    NotFoundComponent,
    CareerComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(routeArray)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
