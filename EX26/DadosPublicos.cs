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
				Console.Write("Quantas pessoas ser�o analisadas? ");
				if (int.TryParse(Console.ReadLine(), out int nPessoas))
				{
					Quantidade = nPessoas;
					return;
				}
				LimparTela.Executar();
			}
		}
	}
}