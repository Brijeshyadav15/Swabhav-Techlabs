import { StarComponent } from './star.component';
import { ProductDataService } from './product-data.service';
import { routeArray } from './RouteConfig';
import { ProductListComponent } from './product-list.component';
import { ProductDetailComponent } from './product-detail.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './welcome.component';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NotFoundComponent } from './notfound.component';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    ProductDetailComponent,
    ProductListComponent,
    NotFoundComponent,
    StarComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot(routeArray)
  ],
  providers: [ProductDataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
