using System;
using System.Threading; // Essa é a biblioteca da contagemm regressiva.

namespace EX18
{
    class Program
    {
        static void Main(string[] args)
        {
            Contagem(); //Chamada do método.
            Console.WriteLine("Feliz Ano Novo!");
            Console.ReadKey(); // Pausa para não fechar o programa. 
        }
        static void Contagem() // Método criado para criar essa contagem regressiva.
        {
            for (int i = 10; i > 0; i--)
            {
                Console.Clear(); // Limpa o console a cada segundo.
                Console.WriteLine($"Tempo para o Ano Novo: {i}");
                Thread.Sleep(1000); // Um segundo de intervalo a cada contagem.
            }
        }
    }
}