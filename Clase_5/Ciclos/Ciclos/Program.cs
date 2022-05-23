Console.WriteLine("Cuantas vueltas quiere dar?");

var respuesta = "S";
var contador = 0;

while (respuesta.ToUpper()!="N")
{
    contador++;
    Console.WriteLine("Seguimos dando vueltas, vuelta número: " + contador);

    Console.WriteLine("Seguimos?");
    respuesta = Console.ReadLine();
}