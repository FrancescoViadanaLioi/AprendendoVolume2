using System;
using System.Globalization;
using Metodos;

namespace EX25
{
    class Program
    {
        static void Main(string[] args)
        {
            var verificacoes = new Verificacoes();

            int tamanho = verificacoes.TamanhoVetor();
            int[] vetor = verificacoes.LerValoresVetor(tamanho);
            double media = verificacoes.CalcularMedia(vetor);

            Console.WriteLine($"A média dos elementos dos vetores é igual a {media.ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}