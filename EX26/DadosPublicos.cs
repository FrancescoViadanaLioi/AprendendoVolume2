using System;
using Miscelania;

namespace DadosPublicos
{
	public static class NumeroPessoas
	{
		public static int Quantidade;

		public static int Capturar()
		{
			while (true)
			{
				Console.Write("Quantas pessoas serão analisadas? ");
				if (int.TryParse(Console.ReadLine(), out int nPessoas) && nPessoas > 0 ) //Garante que a entrada é válida e o vetor não pode ser nulo ou menor que 1 (pelo menos)
				{
					Quantidade = nPessoas;
					return nPessoas;
				}
				LimparTela.Executar();
			}
		}
	}
}