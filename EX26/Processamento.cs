using System;
using System.Globalization;
using Miscelania;

namespace Processamento
{
	public class EntrarComDados
	{
		public int QuantDePessoas()
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