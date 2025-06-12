using System;
using DadosPublicos;
using Pessoas;

namespace Processamento
{
    public static class DadosEntrada
    {
        public static (string[] nomes, int[] idades, double[] alturas) ObterEntrada()
        {
            NumeroPessoas.Capturar();

            var nomes = new Nomes().InserirNome();
            var idades = new Idades().InserirIdade();
            var alturas = new Alturas().InserirAltura();
            return (nomes, idades, alturas);
        }
    }
    public static class AtribuirCalculos
    {
        public static (double mediaIdade, double mediaAltura) AtribuirMedia(int[] idades, double[] alturas)
        {
            double mediaIdade = Calcular.CalcularMediaIdade(idades);
            double mediaAltura = Calcular.CalcularMediaAltura(alturas);
            return (mediaIdade, mediaAltura);
        }
    }
    public static class Calcular
    {
        public static double CalcularMediaIdade(int[] idades)
        {
            double soma = 0;
            foreach(var idade in idades)
            {
                soma += idade;
            }
            return soma / idades.Length;
        }
        public static double CalcularMediaAltura(double[] alturas)
        {
            double soma = 0;
            foreach(var altura in alturas)
            {
                soma += altura;
            }
            return soma / alturas.Length;
        }
    }
}