import { Component } from '@angular/core';
import { CardComponent } from '../../Components/card/card.component';
import { ProductosComponent } from '../../Components/productos/productos.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-productos-info',
  imports: [CardComponent,ProductosComponent, CommonModule],
  templateUrl: './productos-info.component.html',
  styleUrl: './productos-info.component.css'
})

export class ProductosInfoComponent {
  items = [
    {id: 1, nombre: 'Producto A', descripciion: 'Descripción del producto A', precio:100},
    {id: 2, nombre: 'Producto B', descripciion: 'Descripción del producto A', precio:200},
    {id: 3, nombre: 'Producto C', descripciion: 'Descripción del producto A', precio:300},
    {id: 4, nombre: 'Producto D', descripciion: 'Descripción del producto A', precio:400},
    {id: 5, nombre: 'Producto E', descripciion: 'Descripción del producto A', precio:500},
  ]

  itemSeleccionado: any = null;

  seleccionarItem(item:any){
    this.itemSeleccionado = item;
  }
}
