using System;
using System.Globalization;
using Processamento;

namespace Saida
{
    public static class SaidaDados
    {
        public static void Exibir(string[] nomes, int[] idades, double[] alturas)
        { 
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Pessoa {i + 1}:");
                Console.WriteLine($"Nome: {nomes[i]}");
                Console.WriteLine($"Idade: {idades[i]} anos");
                Console.WriteLine($"Altura: {alturas[i].ToString("F2", CultureInfo.InvariantCulture)}m");
            }
            Console.WriteLine($"A média das idades dessas pessoas é de {Calcular.CalcularMediaIdade(idades).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A média das alturas dessas pessoas é de {Calcular.CalcularMediaAltura(alturas).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}