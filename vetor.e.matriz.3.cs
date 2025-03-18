using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 5];  
        int somaLinha;

        
        for (int i = 0; i < 3; i++)  
        {
            for (int j = 0; j < 5; j++) 
            {
                Console.Write($"Digite o número para a posição [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

       
        for (int i = 0; i < 3; i++)  
        {
            somaLinha = 0;
            for (int j = 0; j < 5; j++)  
            {
                somaLinha += matriz[i, j];
            }
            Console.WriteLine($"Soma da linha {i + 1}: {somaLinha}");
        }
    }
}
