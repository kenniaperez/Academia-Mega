//Se declara el tipo de archivo JS 
/** @type {import ('tailwindcss').Config}}*/

//Se indica donde se metera el tailwind (Se indica que en todo lo de razer vamos a usar tailwin )
module.exports = {
    content: ["./**/*.razor",
        "./wwwroot/index.html"
    ],
    //Se agrega un tema
    theme: {
        extend: {},
    },
    plugins: [
    ],
}