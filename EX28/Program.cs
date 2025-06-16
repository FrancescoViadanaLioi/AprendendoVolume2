using System;
using Manipulacao;
using Saida;

namespace EX28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = EntradaDeDados.CapturarTamMatriz();
            OperarMatriz.PreencherMatriz(matriz);
            ExibirValores.ExibirMatriz(matriz);
            Console.ReadKey();
        }
    }
}
