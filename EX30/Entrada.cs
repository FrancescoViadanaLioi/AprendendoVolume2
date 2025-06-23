using System;
using Miscelania;

namespace Entrada
{
    public class TamanhoMatriz
    {
        public static int[,] CriarMatriz()
        {
            while (true)
            {
                Console.Write("Digite o número de linhas e colunas da matriz, separados por espaço: ");
                string? input = Console.ReadLine();
                string[] vect = input.Split(' ');
                if (
                    (input != null && vect != null && vect.Length == 2) &&
                    (int.TryParse(vect[0], out int m) && int.TryParse(vect[1], out int n)) &&
                    (m > 0 && n > 0))
                {
                    return new int[m, n];
                }
                Limpar.LimparTela();
            }
        }
    }
}