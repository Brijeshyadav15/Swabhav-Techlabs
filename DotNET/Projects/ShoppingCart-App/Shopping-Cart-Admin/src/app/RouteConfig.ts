import { DashboardComponent } from './../pages/Dashboard/dashboard.component';
import { RegisterComponent } from './../pages/register/register.component';
import { LoginComponent } from './../pages/login/login.component';
import { ProductComponent } from '../pages/products/product.component';

import { Routes } from '@angular/router';


export const routeArray : Routes = [    
    {path:"", component: LoginComponent},
    {path:"Register", component: RegisterComponent},
    {path:"Login", component: LoginComponent},
    {path:"Dashboard", component: DashboardComponent},
    {path:"Products", component: ProductComponent}
]; 