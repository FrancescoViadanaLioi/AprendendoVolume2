using System;
using System.Globalization;
using System.Threading;
using Processamento;

namespace Saida
{
    public static class SaidaDados
    {
        public static void Exibir(string[] nomes, int[] idades, double[] alturas, double mediaIdade, double mediaAltura)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Pessoa {i + 1}");
                Console.WriteLine($"Nome: {nomes[i]}");
                Console.WriteLine($"Idade: {idades[i]} anos");
                Console.WriteLine($"Altura: {alturas[i].ToString("F2", CultureInfo.InvariantCulture)}m");
                Thread.Sleep(3000); //Pausa de 3 segundos antes de limpar a tela e passar pra próxima pessoa.
                Console.Clear();
            }
            Console.WriteLine($"A média das idades dessas pessoas é de {mediaIdade.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A média das alturas dessas pessoas é de {mediaAltura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}