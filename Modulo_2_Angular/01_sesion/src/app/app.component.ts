import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Bienvenidos a mi pagina web Proyecto 1';
  name = 'Kennia Valentina Perez de Leon'
  dato = "Veterinario"
  dato2 = 140
}
