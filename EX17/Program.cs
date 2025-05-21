using System;

namespace EX17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = LerQntdNumeros();
            int soma = Repeticao(n);
            Console.WriteLine($"A soma dos números é {soma}");
            Console.ReadKey();
        }

        static int LerQntdNumeros()
        {
            while (true)
            {
                Console.Write("Quantos números você quer digitar? ");
                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    return n;
                }
                Console.WriteLine("Você digitou um valor inválido, verifique e tente novamente.\n(Pressione qualquer tecla para limpar e continuar o código)");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int Repeticao(int n)
        {
            int x, soma = 0;
            for (int i = 0; i < n;)
            {
                Console.Write($"Agora, digite o número {i+1}: ");
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Você digitou um valor inválido, verifique e tente novamente.\n(Pressione qualquer tecla para limpar e continuar o código)");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                soma += x;
                i++;
            }
            return soma;
        }
    }
}
