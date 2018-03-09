import { RegisterComponent } from './../pages/register/register.component';
import { LoginComponent } from './../pages/login/login.component';

import { Routes } from '@angular/router';

export const routeArray : Routes = [    
    //{ path: 'Delete/:id', component: CareerComponent },
    {path:"Register", component: RegisterComponent},
];