Console.Clear();

Console.WriteLine("Este programa calcula la superficie de un rectágulo");
Console.WriteLine();

//    decimal v = decimal.Parse("222");

Console.WriteLine("Ingrese la base del rectángulo");
//string baseRectanguloTexto = Console.ReadLine();
//double baseRectangulo = double.Parse(baseRectanguloTexto); // Convierte "Console.ReadLine()" a double, porque el readLine puede contener letras

double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectángulo");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = baseRectangulo * alturaRectangulo;

Console.Write("La superficie del rectángulo es: ");
Console.WriteLine(superficieRectangulo);

bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    //Mostrar mensaje solamente su es mayor a diez
    Console.WriteLine("La superficie del rectángulo es mayor a diez");
}

Console.ReadKey();