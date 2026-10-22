// Programa que solicita una base y un exponente al usuario y calcula la potencia correspondiente utilizando recursividad.
using System;
class Program
{
    static long Potencia(int baseNum, int exponente)
    {
        if(exponente == 0)
            return 1;
            return baseNum * Potencia(baseNum, exponente - 1);
    }
    static void Main()
    {
        Console.WriteLine("Ingrese la base:");
        int baseNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el exponente (0 a 30):");
        int exponente = int.Parse(Console.ReadLine());
        if (exponente < 0 || exponente > 30)
        {
            Console.WriteLine("El exponente debe estar entre 0 y 30.");
            return;
        }
        Console.WriteLine("Resultado: " + Potencia(baseNum, exponente));
    }
}