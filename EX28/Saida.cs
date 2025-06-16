using System;
using Manipulacao;

namespace Saida
{
    public class ExibirValores
    {
        public static void ExibirMatriz(int[,] matriz)
        {
            for(int i = 0;i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j <matriz.GetLength; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}