Console.WriteLine("Desea continuar? (S/N)");
var texto = Console.ReadLine();

if (texto.ToUpper() == "S") //ToUpper convierte todo a mayúscula
{
    Console.WriteLine("Usted ingreso que SI");

}else if(texto.ToLower()=="n")
{
    Console.WriteLine("Usted ingreso que no");
}
else
    Console.WriteLine("Usted usted no entendio nada");