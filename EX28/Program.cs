using System;

namespace EX28
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            while (true)
            {
                Console.Write("Digite o número de linhas e colunas da matriz: ");
                string[] input = Console.ReadLine()!.Split(' ');

                if (input.Length == 2 && int.TryParse(input[0], out m) && int.TryParse(input[1], out n))
                {
                    break;
                }

                Console.WriteLine("Entrada inválida. Tente novamente.");
                Console.ReadKey();
                Console.Clear();
            }

            int[,] A = new int[m, n];

            Console.WriteLine("Digite os valores da matriz linha por linha:");

            for (int i = 0; i < m; i++)
            {
                while (true)
                {
                    string[] row = Console.ReadLine()!.Split(' ');

                    if (row.Length == n)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            A[i, j] = int.Parse(row[j]);
                        }
                        break;
                    }

                    Console.WriteLine($"Você precisa digitar exatamente {n} valores.");
                }
            }

            Console.WriteLine("Matriz digitada:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
