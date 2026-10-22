// Programa que determina si un número es par o impar, despues de que el usuario ingrese un número.
using System;
class Program
{
    static bool EsPar(int n)
    {
        if(n == 0)
            return true;
            return Impar(n - 1);
    }
    static bool Impar(int n)
    {
        if(n == 0)
            return false;
            return EsPar(n - 1);
    }
    static void Main()
    {
        Console.WriteLine("Ingrese un número entre 0 y 1000: ");
        int n = int.Parse(Console.ReadLine());
        if(n < 0 || n > 1000)
        {
            Console.WriteLine("ingrese un número entre 0 y 1000.");
            return;
        }
        if(EsPar(n))
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}