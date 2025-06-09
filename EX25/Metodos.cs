using System;
using Utilitarios;

namespace Metodos
{
    public class Verificacoes
    {
        public int TamanhoVetor()
        {
            while (true)
            {
                int tamanhoVetor;
                Console.Write("Digite o tamanho do vetor: ");
                if (int.TryParse(Console.ReadLine(), out tamanhoVetor) && tamanhoVetor > 0) return tamanhoVetor;
                Limpar.LimparTela();
            }
        }
        public int[] LerValoresVetor(int tamanhoVetor)
        {
            int[] vetor = new int[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
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
        public double CalcularMedia(int[] vetor)
        {
            int soma = 0;

            foreach(int valor in vetor)
            {
                soma += valor;
            }
            return (double)soma / vetor.Length;
        }
    }
}