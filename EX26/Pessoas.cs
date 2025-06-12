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
}