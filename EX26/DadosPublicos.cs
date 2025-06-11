using System;
using Miscelania;

namespace DadosPublicos
{
	public class NumeroDePessoas
	{
		public static int QuantDePessoas()
		{
			while (true)
			{
				Console.Write("Quantas pessoas serão analisadas? ");
				if (int.TryParse(Console.ReadLine(), out int nPessoas)) return nPessoas;
				LimparTela.Executar();
			}
		}
	}
}