import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-card',
  imports: [FormsModule],
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})

export class CardComponent{
  title = "Hola";
  contenido = "Esto es una card que vamos a estar trabajando";
  botonText = "Conocer mas";

  img = "https://picsum.photos/640/640?r" + Math.random()
  yo = "https://img-c.udemycdn.com/course/125_H/1509816_dff8.jpg"

  nombre = ""

  mostrarAlerta(){
    alert("Hola kennia");
  }
}
