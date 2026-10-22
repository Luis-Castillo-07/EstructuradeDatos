// Progrma que pide dos números y calcula la suma de todos los números desde ese valor hasta 1 usando recursividad
using System;
class Program
{
    static int Suma(int n)
{
    if(n <= 0)
        return 0;
    return n + Suma(n - 1);
}
static void Main()
{
    Console.WriteLine("Ingrese un número:");
    int n = int.Parse(Console.ReadLine());
    if(n < 0 || n > 100)
        {
            Console.WriteLine("El número debe estar entre 0 y 100.");
            return;
        }
    Console.WriteLine("La suma es: " + Suma(n));
}
}