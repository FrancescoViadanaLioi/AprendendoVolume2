using System;
using System.Globalization;

namespace EX11
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, soma = 0, cont = 0;
            double media = 0;

            // Primeira leitura FORÇADA: usuário só sai daqui digitando uma idade válida >= 0
            while (true)
            {
                LerIdade(ref idade);
                if (idade >= 0) break;
                Console.WriteLine("Não começa com gracinha. Digite uma idade válida.\n");
            }

            // Loop de coleta de idades
            while (idade >= 0)
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
