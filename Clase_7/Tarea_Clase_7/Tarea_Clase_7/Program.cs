/*
Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

Recuerden que no nos deben adjuntar archivos comprimidos ni imagenes.
Pueden adjuntarnos el archivo .cs, o el codigo como texto.
*/

int[] numeros = new int[10];                //Creo el array

for (int i=0; i < numeros.Length; i++)      //Ciclo for para pedir los números y los ubico en el array
{
    Console.WriteLine($"por favor ingrese el número:{i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}

var suma = 0;                           //Genero la variable de acumulación "suma"

for (int i=0; i<numeros.Length; i++)    //hago un ciclo for para sumar todos los numero y acumularlos en "suma"
{
    suma = suma + numeros[i];
}

int mayor = numeros[0];                          //declaro variable para numero mayor
int menor = numeros[0];                 //declaro variable para  número menor y le pongo de parámetro el número de la posicion 0 de array

for (int i=0; i<numeros.Length; i++)    //genero un for para encontrar el mayor y menor
{
    if (numeros[i]>mayor)
    {
        mayor = numeros[i];
    }
    else if (numeros[i]<menor)
    {
        menor = numeros[i];        
    }
}

double promedio = suma / numeros.Length;            //Promedio

for (int i=0; i<numeros.Length; i++)                //un for para imprimir cada número
{
    Console.WriteLine($"El número {i + 1} es: {numeros[i]}");
}

Console.WriteLine($"La suma de todos los número ingresados es: {suma}");
Console.WriteLine($"El mayor número de todos los ingresados es: {mayor}");
Console.WriteLine($"El menor número de todos los ingresados es: {menor}");
Console.WriteLine($"El promedio de todos los números ingresados es: {promedio}");