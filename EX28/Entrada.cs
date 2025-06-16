using System;
using Miscelania;

namespace Manipulacao
{
	public static class EntradaDeDados
	{
		public static int[,] CapturarTamMatriz()
		{
			int m, n;

			while (true)
			{
				Console.Write("Digite o número de linhas e de colunas da matriz separadas por espaço: ");
				string[] vect = Console.ReadLine()!.Split(' ');
				if (vect.Length == 2 && (int.TryParse(vect[0], out m) && m > 0) && (int.TryParse(vect[1], out n) && n > 0)) return new int[m,n];
				Limpar.LimparTela();
			}
		}
	}
	public static class OperarMatriz
	{
		public static int[,] PreencherMatriz(int[,] matriz)
		{
			for(int i = 0; i < matriz.GetLength(0); i ++)
			{
				for(int j = 0; j < matriz.GetLength(1); j++)
				{
					while(true)
					{
						Console.Write($"Digite o elemento na posição [{i},{j}]: ");
						if(int.TryParse(Console.ReadLine(), out int valor))
						{
							matriz[i, j] = valor;
							break;
						}
						Limpar.LimparTela();
					}
				}
			}
			return matriz;
		}
	}
}