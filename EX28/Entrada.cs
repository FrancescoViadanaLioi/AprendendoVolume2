using System;
using Miscelania;

namespace Manipulacao
{
    public static class EntradaDeDados
    {
        public static int[,] CapturarTamMatriz()
        {
            int m, n;

            while (true)
            {
                Console.Write("Digite o número de linhas e de colunas da matriz separadas por espaço: ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    Limpar.LimparTela();
                    continue;
                }
                string[] vect = input.Split(' ');
                if (vect.Length == 2 && (int.TryParse(vect[0], out m) && m > 0) && (int.TryParse(vect[1], out n) && n > 0)) return new int[m, n];
                Limpar.LimparTela();
            }
        }
    }
    public static class OperarMatriz
    {
        public static void PreencherMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = LerElementosPosicao(i, j);
                }
            }
        }
        private static int LerElementosPosicao(int i, int j)
        {
            while(true)
            {
                Console.Write($"Digite o elemento da posição [{i},{j}]: ");
                string? input = Console.ReadLine();
                if (input != null && int.TryParse(input, out int valor)) return valor;
                Limpar.LimparTela();
            }
        }
    }
}
