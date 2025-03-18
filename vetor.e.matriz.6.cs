using System;

class Program
{
    static void Main()
    {
        char[,] tabuleiro = new char[3, 3];
        int jogador = 0;
        bool jogoEmAndamento = true;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }

        while (jogoEmAndamento)
        {
            Console.Clear();
            MostrarTabuleiro(tabuleiro);
            jogador++;
            char simbolo = jogador % 2 == 0 ? 'O' : 'X';
            Console.WriteLine($"Jogador {(jogador % 2 == 0 ? 2 : 1)} ({simbolo}), escolha uma posição entre 1 e 9:");

            int escolha = int.Parse(Console.ReadLine()) - 1;
            int linha = escolha / 3;
            int coluna = escolha % 3;

            if (tabuleiro[linha, coluna] != ' ')
            {
                Console.WriteLine("Essa posição já está ocupada! Tente novamente.");
                jogador--;
                continue;
            }

            tabuleiro[linha, coluna] = simbolo;

            if (VerificarVencedor(tabuleiro, simbolo))
            {
                Console.Clear();
                MostrarTabuleiro(tabuleiro);
                Console.WriteLine($"Jogador {(jogador % 2 == 0 ? 2 : 1)} ({simbolo}) venceu!");
                break;
            }

            if (VerificarEmpate(tabuleiro))
            {
                Console.Clear();
                MostrarTabuleiro(tabuleiro);
                Console.WriteLine("O jogo empatou!");
                break;
            }
        }
    }

    static void MostrarTabuleiro(char[,] tabuleiro)
    {
        Console.WriteLine("Tabuleiro:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("-----");
        }
    }

    static bool VerificarVencedor(char[,] tabuleiro, char simbolo)
    {
        for (int i = 0; i < 3; i++)
        {
            if ((tabuleiro[i, 0] == simbolo && tabuleiro[i, 1] == simbolo && tabuleiro[i, 2] == simbolo) ||
                (tabuleiro[0, i] == simbolo && tabuleiro[1, i] == simbolo && tabuleiro[2, i] == simbolo))
            {
                return true;
            }
        }

        if ((tabuleiro[0, 0] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 2] == simbolo) ||
            (tabuleiro[0, 2] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 0] == simbolo))
        {
            return true;
        }

        return false;
    }

    static bool VerificarEmpate(char[,] tabuleiro)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[i, j] == ' ') return false;
            }
        }
        return true;
    }
}
