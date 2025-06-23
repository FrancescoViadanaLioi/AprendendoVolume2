using System;

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
        public static void ExibirNegativos(int[,] matriz)
        {
            bool temNegativo = false;
            Console.WriteLine("NÚMEROS NEGATIVOS");
            foreach (int num in matriz)
            {
                if (num < 0)
                {
                    Console.Write($"{num} ");
                    temNegativo = true;
                }
            }
            if(!temNegativo)
            {
                Console.WriteLine("Não há elementos negativos.");
            }
        }
    }
}