// Programa que solicita un número positivo y calcula la suma de todos sus digitos.
using System;
class Program
{
    static int SumarDigitos(int n)
    {
        if(n == 0)
            return 0;
            return n % 10 + SumarDigitos(n / 10);
    }
    static void Main()
    {
        Console.WriteLine("Ingrese un número positivo:");
        int n = int.Parse(Console.ReadLine());
        if(n < 0)
        {
            Console.WriteLine("Ingrese un número positivo.");
            return;
        }
        Console.WriteLine("La suma de de los digitos: " + SumarDigitos(n));
    }
}