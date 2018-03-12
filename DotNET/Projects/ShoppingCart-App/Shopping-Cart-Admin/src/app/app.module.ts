import { ProductCategoryDetailComponent } from './../pages/productCategoryDetails/productCategoryDetails.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Http, HttpModule } from '@angular/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { routeArray } from './RouteConfig';

import { AppComponent } from './app.component';
import { LoginComponent } from '../pages/login/login.component';
import { RegisterComponent } from '../pages/register/register.component';
import { ProductComponent } from '../pages/products/product.component';
import { DashboardComponent } from './../pages/Dashboard/dashboard.component';
import { OrdersComponent } from './../pages/orders/order.component';
import { ProductCategoriesComponent } from './../pages/productCategories/productCategories.component';
import { ProductDetailComponent } from './../pages/productdetails/productDetail.component';
import { LogoutComponent } from '../pages/logout.component.ts/logout.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    ProductComponent,
    DashboardComponent,
    ProductCategoriesComponent,
    OrdersComponent,
    ProductDetailComponent,
    ProductCategoryDetailComponent,
    LogoutComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routeArray)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
