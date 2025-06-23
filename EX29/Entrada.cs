using System;
using Miscelania;

namespace Entrada
{
    public class TamanhoMatriz
    {
        public static int[,] ConfigurarMatriz()
        {
            while (true)
            {
                Console.Write("Digite o tamanho da matriz(quadrada): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int m) && m > 0) return new int[m,m];
                Limpar.LimparTela();
            }
        }
    }
    public class ElementosMatriz
    {
        public static void PreencherMatriz(int[,] matriz)
        {
           for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = LerElementosMatriz(i, j);
                }
            }
        }
        private static int LerElementosMatriz(int i, int j)
        {
            while (true)
            {
                Console.Write($"Digite o elemento da posição [{i}][{j}]: ");
                string? input = Console.ReadLine();
                if (input != null && int.TryParse(input, out int valor)) return valor;
                Limpar.LimparTela();
            }
        }
    }
}