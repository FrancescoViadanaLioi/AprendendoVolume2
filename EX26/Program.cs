using System;
using Processamento;
using Saida;

namespace EX26
{
    class Program
    {
        static void Main(string[] args)
        {
            var (nomes, idades, alturas) = DadosEntrada.ObterEntrada();
            var (mediaIdade, mediaAltura) = AtribuirCalculos.AtribuirMedia(idades, alturas);
            SaidaDados.Exibir(nomes, idades, alturas, mediaIdade, mediaAltura);
            Console.ReadKey();
            Console.Clear();
        }

    }
}