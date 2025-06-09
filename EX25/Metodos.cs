using System;
using System.Globalization;
using Utilitarios;

namespace Metodos
{
    public class Verificacoes
    {
        public int TamanhoVetor()
        {
            while (true)
            {
                int Nvet;
                Console.Write("Digite o tamanho do vetor: ");
                if (int.TryParse(Console.ReadLine(), out Nvet) && Nvet > 0) return Nvet;
                Limpar.LimparTela();
            }
        }
        public int[] LerValoresVetor(int Nvet)
        {
            int[] vetor = new int[Nvet];

            for (int i = 0; i < Nvet; i++)
            {
                while (true)
                {
                    Console.Write($"Digite o valor do vetor {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out vetor[i])) break;
                    Limpar.LimparTela();
                }
            }
            return vetor;
        }
        public double CalculoMedia(int[] vetor)
        {
            int soma = 0;

            foreach(int valor in vetor)
            {
                soma += valor;
            }
            double media = (double)soma / vetor.Length;

            return media;
        }
    }
}