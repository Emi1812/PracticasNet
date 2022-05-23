// Ejemplo de switch

Console.WriteLine("Ingrese el primer número");
double numero1=double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
double numero2 = double.Parse(Console.ReadLine());


Console.WriteLine("1-Suma");
Console.WriteLine("2-Resta");
Console.WriteLine("3-Multiplicacion");
Console.WriteLine("4-División");

Console.WriteLine("Ingrese la operación a realizar");
string operacion=Console.ReadLine();



double resultado = 0;

switch (operacion)
{
    case "1":
        resultado=numero1+numero2;
        break;
    case "2":
        resultado = numero1 - numero2;
        break;
    case"3":
        resultado = numero1 * numero2;
        break;
    case"4" when numero2 !=0:
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Ingreso una opcion no valida");
        break;
}

Console.WriteLine("El resultado es "+resultado);