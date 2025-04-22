const capitalizar = require("./capitalizar");

test("capitalizar hola -> Hola", ()=>{
    expect(capitalizar("hola")).toBe("Hola");
})

test("capitalizar JAVASCRIPT -> JAVASCRIPT", ()=>{
    expect(capitalizar("JAVASCRIPT")).toBe("Javascript");
})