import { NotFoundComponent } from './notfound.component';
import { AddComponent } from './add.component';
import { EditComponent } from './edit.component';
import { HomeComponent } from './home.component';
import { Routes } from '@angular/router';

export const routeArray : Routes = [
    {path:"Home", component: HomeComponent},
    // {path:" ", redirectTo: HomeComponent},
    { path: 'Edit/:id', component: EditComponent },
    {path:"Edit", component: EditComponent},
    //{ path: 'Delete/:id', component: CareerComponent },
    {path:"Add", component: AddComponent},
    { path: 'error', component: NotFoundComponent }
];