import { Routes } from '@angular/router';
import { ProductManagerComponent } from './Components/product-manager/product-manager.component';
import { CardComponent } from './Components/card/card.component';
import { TodoComponent } from './Components/todo/todo.component';
import { TarjetaComponent } from './Components/tarjeta/tarjeta.component';
import { ErrorComponent } from './Page/error/error.component';
import { HomeComponent } from './Page/home/home.component';
import { ProductosInfoComponent } from './Page/productos-info/productos-info.component';
import { ServicePageComponent } from './Page/service-page/service-page.component';

export const routes: Routes = [
    {
        path:'',
        component: ServicePageComponent
    },
    {
        path:'componentes',
        component: ProductosInfoComponent
    },
    {
        path:'home',
        component: HomeComponent
    },
    { 
        path:'card',
        component: CardComponent
    },
    {
        path:'todo',
        component: TodoComponent
    },
    {
        path:'gestor',
        component: ProductManagerComponent
    },
    {
        path:'tarjeta',
        component: TarjetaComponent
    },
    {
        path:'**',
        component: ErrorComponent
    },
];
