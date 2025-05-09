import { Component } from '@angular/core'; 
import { HijoComponent } from '../../Components/hijo/hijo.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home',
  imports: [HijoComponent,CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

  //Simulación de api
  usuarios = [
    {nombre: "Juan", edad:25, profesion: "Ingeniero"},
    {nombre: "Ana", edad:26, profesion: "Diseñadora"},
    {nombre: "Patra", edad:25, profesion: "Ingeniero"},
  ]

  mensajeDelHijo = ""

  recibirMensaje(mensaje: any){
    this.mensajeDelHijo = mensaje
  }

}
