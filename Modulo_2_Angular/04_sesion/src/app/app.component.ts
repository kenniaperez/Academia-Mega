import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Saludo } from './Components/Saludo/saludo.components';
import { CardComponent } from './Components/card/card.component';
import { TarjetaComponent } from './Components/tarjeta/tarjeta.component';
import { CommonModule } from '@angular/common';
import { TodoComponent } from './Components/todo/todo.component';


@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Saludo, CardComponent, TarjetaComponent, CommonModule, TodoComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  title = 'Bienvenidos a mi pagina web Proyecto 1';
  name = 'Kennia Valentina Perez de Leon'
  dato = "Veterinario"
  dato2 = 140
  isVisible = true;
  frutas = ["Manzana", "Platano", "Naranja", "Uva", "Pera", "Piña"]
}
