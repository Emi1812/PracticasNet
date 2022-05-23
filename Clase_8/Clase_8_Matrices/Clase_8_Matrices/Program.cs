﻿/*
Console.WriteLine("Ingrese la cantidad de alumnos");
//Ingresamos el tamaño del vector
int cantidadAlumnos = int.Parse(Console.ReadLine());

// Tipo[] nombre=new tipo[tamaño]
int[] notas = new int[cantidadAlumnos];

Console.WriteLine("Ingrese las notas de cada alumno");

//recorrremos el vector para cargar
for (int posicion=0; posicion<notas.Length; posicion++)
{
    Console.WriteLine($"Nota del alumno N°{posicion + 1}: ");
    notas[posicion] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("================== =============================================");
Console.WriteLine();

for (int posicion = 0; posicion < notas.Length; posicion++)
{
    Console.WriteLine($"La nota del alumno N°{posicion + 1}: {notas[posicion]}");
}
*/




Console.WriteLine("Ingrese las notas de los exámenes");

Console.WriteLine("Ingrese la cantidad de alumnos");
//Determina las columnas
int cantidadAlumnos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de notas por alumno");
//Determina las filas
int cantidadNotas = int.Parse(Console.ReadLine());

//Tipo[] nombre = new tipo[tamañoFilas,tamañoColumnas]
int[,] notas = new int[cantidadNotas, cantidadAlumnos];


//Cantidad de filas
int lengthFilas = notas.GetUpperBound(0)+1; //devuelve el último indice de la matriz, como arranca desde 0 y el último índice es un 4, y como necesitamos un array de 5 elementos, LE SUMAMOS 1

//Cantidad de columnas
int lengthColumnas = notas.GetUpperBound(1) + 1;


//Recorremos las columnas
for (int columna=0; i<lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N°: {columna+1}: ");

    //Recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"Cargue la nota N° {fila+1}");
        notas[fila, columna] = int.Parse(Console.ReadLine());
    }
}

//Recorremos las columnas
for (int columna = 0; i < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine("======================================================================================");
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N°: {columna + 1}: ");

    //Recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"La nota N° {fila + 1}: ");
        Console.WriteLine(notas[fila, columna]);
    }    
}

Console.ReadKey();


