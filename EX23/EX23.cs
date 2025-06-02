using System;

namespace EX23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = EntradaValida();
            int[] vetor = LoopDaMatriz(n);

            Console.Clear();
            
            for(int i = 0; i < vetor.Length;i++)
            {
                Console.WriteLine($"Vetor[{i + 1}]: {vetor[i]}");
            }
            Limpar();
        }
        static int EntradaValida()
        {
            while (true)
            {
                int N;
                Console.Write("Digite a quantidade de elementos do vetor: ");
                if(!int.TryParse(Console.ReadLine(), out N) || N <= 0)
                {
                    Limpar();
                    continue;
                }
                return N;
            }
        }
        static int[] LoopDaMatriz(int N)
        {
            int[] vetor = new int[N];
            
            for (int i =0; i<N;i++)
            {
                while (true)
                { 
                    Console.Clear();
                    Console.Write($"Digite o valor do vetor {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out vetor[i])) break;
                    Limpar();
                }
            }
            return vetor;
            
        }
        static void Limpar()
        {
            Console.WriteLine("Valor inválido, tente de novo.\n(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}