using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        decimal[,] notas = new decimal[10, 3];
        decimal[] medias = new decimal[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            nomes[i] = Console.ReadLine();

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite a nota {j + 1} do aluno {nomes[i]}: ");
                notas[i, j] = decimal.Parse(Console.ReadLine());
            }

            medias[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
        }

        for (int i = 0; i < 10; i++)
        {
            if (medias[i] >= 7.0m)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"Aluno: {nomes[i]}");
            Console.WriteLine($"Notas: {notas[i, 0]} {notas[i, 1]} {notas[i, 2]}");
            Console.WriteLine($"Média: {medias[i]:F2}");
            Console.WriteLine(medias[i] >= 7.0m ? "Aprovado" : "Reprovado");
            Console.ResetColor();
        }
    }
}
