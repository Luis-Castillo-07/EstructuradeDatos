// Programa que invierte los digitos de un numero positivo utliznado recursividad.
using System;
class Program
{
    static long Inveritr(long n, long resultado = 0)
    {
        if (n == 0)
            return resultado;
        else
            return Inveritr(n / 10, resultado * 10 + n % 10);
    }
    static void Main()
    {
        Console.WriteLine("Ingrese un número positivo: ");
        long n = long.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("El número debe ser positivo.");
            return;
        }
        Console.WriteLine("El número invertido es: " + Inveritr(n));
    }
}