import { Component } from '@angular/core';

@Component({
  selector: 'app-card',
  imports: [],
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})

export class CardComponent{
  title = "Hola";
  contenido = "Esto es una card que vamos a estar trabajando";
  botonText = "Conocer mas";
}
