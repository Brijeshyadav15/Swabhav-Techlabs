import { CareerComponent } from './career.component';
import { AboutComponent } from './about.component';
import { HomeComponent } from './home.component';
import { NotFoundComponent } from './notfound.component';
import { Routes } from '@angular/router';

export const routeArray : Routes = [
                            {path:"Home", component: HomeComponent},
                            {path:"About", component: AboutComponent},
                            { path: 'Career/:id', component: CareerComponent },
                            {path:"Career", component: CareerComponent},
                            //{path:"", redirectTo:HomeComponent, pathMatch:'full'},
                            {path:"", component:NotFoundComponent}
];
