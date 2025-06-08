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
    }
}