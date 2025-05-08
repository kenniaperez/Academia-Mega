import { Component } from '@angular/core';

@Component({
    selector: "app-saludo",
    imports: [],
    templateUrl: "./saludo.components.html",
    template: "",
    //styles: "./saludo.components.css"
    styles: `h3{
    background-color: blue;
    color:white}`,
})

export class Saludo{
    name = "Kennia Perez"
}
