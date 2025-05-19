const capitalizar = require("./capitalizar");

test("Capitalizar hola => Hola" , ()=>{
    expect(capitalizar("hol")).toBe("Hola");
})


test("Capitalizar JAVASCRIPT => Javascript" , ()=>{
    expect(capitalizar("JAVASCRIPT")).toBe("Javascript");
})