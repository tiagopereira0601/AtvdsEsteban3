using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        decimal[] precos = new decimal[10];


        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do produto {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Digite o preço do produto {i + 1}: ");
            precos[i] = decimal.Parse(Console.ReadLine());
        }


        Console.Write("Digite o valor máximo para pesquisa: ");
        decimal valorMaximo = decimal.Parse(Console.ReadLine());


        Console.WriteLine("Produtos com preço até o valor informado:");
        for (int i = 0; i < 10; i++)
        {
            if (precos[i] <= valorMaximo)
            {
                Console.WriteLine($"{nomes[i]} - R${precos[i]:F2}");
            }
        }
    }
}
