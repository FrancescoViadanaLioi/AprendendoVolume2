using System;
using System.Globalization;

namespace EX16
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, contIdades = 0, somaIdades = 0;
            float media;

            while (true)
            {
                Entrada(ref idade);
                if (idade < 0) break;

                somaIdades += idade;
                contIdades++;
            }

            if (contIdades > 0)
            {
                media = Saida(somaIdades, contIdades);
                Console.WriteLine($"A média das idades é {media.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Nenhuma idade válida foi digitada.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        static void Entrada(ref int idade)
        {
            bool verificacao;

            while (true)
            {
                Console.Write("Digite a idade (Digite um número negativo para sair do programa): ");
                verificacao = int.TryParse(Console.ReadLine(), out idade);
                if (!verificacao || idade > 120)
                {
                    Console.WriteLine("Digite uma idade válida.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }
        }

        static float Saida(int somaIdades, int contIdades)
        {
            return (float)somaIdades / contIdades;
        }
    }
}
