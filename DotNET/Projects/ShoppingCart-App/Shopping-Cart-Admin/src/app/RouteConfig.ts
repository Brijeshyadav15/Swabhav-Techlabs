import { ProductCategoryDetailComponent } from './../pages/productCategoryDetails/productCategoryDetails.component';
import { Routes } from '@angular/router';

import { LogoutComponent } from './../pages/logout.component.ts/logout.component';
import { ProductDetailComponent } from './../pages/productdetails/productDetail.component';
import { OrdersComponent } from './../pages/orders/order.component';
import { ProductCategoriesComponent } from './../pages/productCategories/productCategories.component';
import { DashboardComponent } from './../pages/Dashboard/dashboard.component';
import { RegisterComponent } from './../pages/register/register.component';
import { LoginComponent } from './../pages/login/login.component';
import { ProductComponent } from '../pages/products/product.component';

export const routeArray : Routes = [    
    {path:"", component: LoginComponent},
    {path:"Register", component: RegisterComponent},
    {path:"Login", component: LoginComponent},
    {path:"Dashboard", component: DashboardComponent},
    {path:"Products", component: ProductComponent},
    {path:"Logout", component: LogoutComponent},
    {path:"Orders", component: OrdersComponent},
    {path:"ProductCategories", component: ProductCategoriesComponent},
    {path:"ProductDetail/:ProductId", component: ProductDetailComponent},
    {path:"ProductDetail", component: ProductDetailComponent},
    {path:"ProductCategoriesDetail/:Id", component: ProductCategoryDetailComponent},
    {path:"ProductCategoriesDetail", component: ProductCategoryDetailComponent}
]; 