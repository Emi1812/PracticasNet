// Ejemplo de condicional If


Console.Write("Ingrese su edad: "); // Le pedimos al usuario que ingrese su edad
int edad = int.Parse(Console.ReadLine()); //Obtenemos la edad por teclado

Console.WriteLine("Ingrese su equipo de futbol: ");

string equipo = Console.ReadLine();

Console.WriteLine("La edad ingresada es: " + edad);

/*
AND -> && (Y)
OR -> || (O)
Igual que -> ==
Distinto que -> !=
 */
bool condicion = edad < 18 && equipo == "River";

if (condicion) //Evaluamos la edad
{
    //Intrucciones si se cumple
    Console.WriteLine("Usted es menor de edad");

    Console.WriteLine("Prohibida la entrada");
}
else
{
    //Instrucciones si no se cumple la condiciones evaluada
    Console.WriteLine("Usted es mayor de edad.");
}