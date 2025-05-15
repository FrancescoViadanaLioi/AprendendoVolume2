using System;
using System.Globalization;

namespace EX14
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, Media;

            while (true)
            {
                Console.Write("Digite o valor de N1: ");
                if(!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out N1!) || N1 < 0 || N1 >10)
                {
                    Console.Write("Entrada inválida, tente novamente.\n");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Write("Digite o valor de N2: ");
                if(!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out N2!) || N2 < 0 || N2 >10)
                {
                    Console.Write("Entrada inválida, tente novamente.\n");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }
            Media = (N1 + N2) / 2;
            if (Media >= 6)
            {
                Console.WriteLine($"Aprovado com média {Media.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"Reprovado com média {Media.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}