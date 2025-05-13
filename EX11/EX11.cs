using System;
using System.Globalization;

namespace EX011
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, soma = 0, cont = 0;
            double media = 0;

            // Primeira leitura FORÇADA: usuário só sai daqui digitando uma idade válida.Isto é, maior ou igual a zero e menor que 120.
            // Se o usuário digitar uma idade negativa ou um número maior que 120, o programa NÃO sai do loop.
            while (true)
            {
                LerIdade(ref idade);
                if (idade >= 0 && idade <= 120) break;
                Console.WriteLine("Digite uma idade válida.\n");
            }

            // Loop de coleta de idades
            while (idade >= 0 && idade <= 120)
            {
                soma += idade;
                cont++;
                LerIdade(ref idade);
            }

            media = (double)soma / cont;
            Console.WriteLine($"A média das idades é: {media.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }

        static void LerIdade(ref int idade)
        {
            Console.Write("Digite a idade: ");
            int.TryParse(Console.ReadLine(), out idade);
        }
    }
}
