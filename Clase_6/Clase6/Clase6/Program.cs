// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Bucle DO-WHILE (hacer-mientras)
//Primero se ejecuta el codigo y despues se pregunta la condicion



var repuesta = "S";
var nombre = "";

do
{
    Console.Clear();
    Console.WriteLine("¿Me dirías tu nombre, por favor?");
    nombre = Console.ReadLine();
    Console.WriteLine($"¡Hola {nombre}!");
    Console.WriteLine("¿Quieres continuar? Elije una opción: \n1: S \n2: N");
    repuesta = Console.ReadLine();
}
while (repuesta.ToUpper() == "S");

if (repuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado");
}
else
{
    Console.WriteLine("Opción no válida");
}


/*
Puedo declarar multiples variables en una sola linea utilizando "var"

En que parte deñ código debo inicializar una variable para poder leer su valor?
a) Al princio del pro