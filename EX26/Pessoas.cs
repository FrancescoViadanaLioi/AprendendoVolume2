using System;
using System.Globalization;
using System.Linq;
using Miscelania;
using DadosPublicos;

namespace Pessoas
{
    public class Nomes
    {
        public string[] InserirNome()
        {
            string[] nomes = new string[NumeroPessoas.Quantidade];
            
            for(int i = 0; i < nomes.Length;i++)
            {
                while (true)
                {
                    Console.Write($"Insira o nome da pessoa {i + 1}: ");
                    string nome = Console.ReadLine();

                    if (NomeEhValido(nome))
                    {
                        nomes[i] = nome;
                        break;
                    }
                    LimparTela.Executar();
                }
            }
            Console.Clear();
            return nomes;
        }
        private bool NomeEhValido(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome)) return false;
            return nome.All(char.IsLetter);
        }
    }
    public class Idades
    {
        public int[] InserirIdade()
        {
            int[] idades = new int[NumeroPessoas.Quantidade];

            for (int i = 0; i < idades.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Digite a idade da pessoa {i + 1}: ");
                    if(int.TryParse(Console.ReadLine(), out int idade) && idade > 0)
                    {
                        idades[i] = idade;
                        break;
                    }
                    LimparTela.Executar();
                }
            }
            Console.Clear();
            return idades;
        }
    }
    public class Alturas
    {
        public double[] InserirAltura()
        {
            double[] alturas = new double[NumeroPessoas.Quantidade];

            for (int i = 0; i < alturas.Length; i++)
            {
                while(true)
                {
                    Console.Write($"Digite a altura da pessoa {i + 1}: ");
                    if(double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double altura) && (altura >= 1 && altura <= 2.50))
                    {
                        alturas[i] = altura;
                        break;
                    }
                    LimparTela.Executar();
                }
            }
            Console.Clear();
            return alturas;
        }
    }
}