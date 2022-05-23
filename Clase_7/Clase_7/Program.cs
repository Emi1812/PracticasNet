// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] Cars = { "Ford", "Fiat", "BMW", "Toyota" };

Console.WriteLine(Cars[0]);                 //Cual es el primer elemento de una matriz? 0 o 1?
//--------------------------------------------------------------------------------------------------------------------
string[] Frutas=new string[4];

Frutas[0] = "Pera";
Frutas[1] = "Manzana";
Frutas[2] = "Banana";
Frutas[3] = "Kiwi";
//---------------------------------------------------------------------------------------------------------------------
int[] numeros = new int[5];
Console.WriteLine($"el array tiene {numeros.Length} posiciones");
ints[0] = int.Parse(Console.ReadLine());
ints[1] = int.Parse(Console.ReadLine());
ints[2] = int.Parse(Console.ReadLine());
ints[3] = int.Parse(Console.ReadLine());
ints[4] = int.Parse(Console.ReadLine());


for(int i=0; i<numeros.Length; i++)
{
    Console.WriteLine($"por favor ingrese el número: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}

var suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma = suma + numeros[i];
}

Console.WriteLine($"valor de suma = {suma}");

Console.WriteLine("Los valores son: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}


//cual es la diferencia entre un acumulador y un contador