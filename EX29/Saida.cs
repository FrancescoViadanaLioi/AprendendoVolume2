using System;
using Entrada;

namespace Saida
{
    public class Exibir
    {
        public static void ExibirDiagonais(int[,] matriz)
        {
            Console.WriteLine("DIAGONAL PRINCIPAL");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{matriz[i, i]} ");
            }
            Console.WriteLine();
        }
    }
}