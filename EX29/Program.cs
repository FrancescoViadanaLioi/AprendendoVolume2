using System;
using Entrada;
using Saida;

namespace EX29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = TamanhoMatriz.ConfigurarMatriz();
            ElementosMatriz.PreencherMatriz(matriz);
            Exibir.ExibirMatriz(matriz);
            Exibir.ExibirDiagonais(matriz);
            Exibir.ExibirNegativos(matriz);
            Console.ReadKey();
        }
    }
}