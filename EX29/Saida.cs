using System;
using Entrada;

namespace Saida
{
    public class Exibir
    {
        public static void ExibirDiagonais(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}