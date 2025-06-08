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
                var valid = Console.ReadLine();
                if (int.TryParse(valid, out Nvet) && Nvet > 0) return Nvet;
                Limpar.LimparTela();
            }             
        }
        public int[] Loop(int Nvet)
        {
            int[] vetor = new int[Nvet];

            for (int i = 0; i < Nvet; i++)
            {
                while(true)
                {
                    Console.Write($"Digite o valor do vetor {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out vetor[i])) break;
                    Limpar.LimparTela();
                }
            }
            return vetor;
        }
    }
}