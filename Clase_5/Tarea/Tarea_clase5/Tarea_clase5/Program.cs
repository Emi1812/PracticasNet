var repuesta = "S";
var nombre = "";

while (repuesta.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("¿Me dirías tu nombre, por favor?");
    nombre = Console.ReadLine();
    Console.WriteLine($"¡Hola {nombre}!");
    Console.WriteLine("¿Quieres continuar? Elije una opción: \n1: S \n2: N");
    repuesta = Console.ReadLine();
 }
if (repuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado");
}
else
{
    Console.WriteLine("Opción no válida");
}

