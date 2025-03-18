using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[15];

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números nas posições pares:");
        for (int i = 0; i < 15; i += 2)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
