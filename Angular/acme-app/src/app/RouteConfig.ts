import { NotFoundComponent } from './notfound.component';
import { ProductDetailComponent } from './product-detail.component';
import { WelcomeComponent } from './welcome.component';

import { Routes } from '@angular/router';
import { ProductListComponent } from './product-list.component';

export const routeArray : Routes = [
                            {path:"Welcome", component: WelcomeComponent},
                            {path:"ProductDetails/:ProductId", component: ProductDetailComponent},
                            {path:"ProductDetails", component: ProductDetailComponent},
                            { path: 'ProductList', component: ProductListComponent },
                            //{path:'', component:WelcomeComponent},
                            //{path:"", component:NotFoundComponent}
];
