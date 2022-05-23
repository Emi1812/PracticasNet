//Ejemplo if-elseif-else

Console.Write("Ingrese la edad: ");
int edad = int.Parse(Console.ReadLine());

if (edad < 0 || edad > 110) 
{
    Console.WriteLine("La edad no es válida");
}
else if (edad<12)
{
    Console.WriteLine("Va a la primaria");
}
else if (edad<18)
{
    Console.WriteLine("Va al secundario");
}
else if (edad<28)
{
    Console.WriteLine("Va a la universidad");
}
else
{
    Console.WriteLine("Va a trabajar");
}