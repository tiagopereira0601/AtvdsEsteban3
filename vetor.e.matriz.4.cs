using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];
        int numero = 1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = numero++;
            }
        }

        Console.WriteLine("Valores das diagonais:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(matriz[i, i] + " ");
            if (i != 2)
            {
                Console.Write(matriz[i, 4 - i] + " ");
            }
        }

        Console.WriteLine();
    }
}
