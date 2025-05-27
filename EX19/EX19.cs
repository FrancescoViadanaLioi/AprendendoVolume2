using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = NumTabuada();
            Tabuada(num);
            Console.ReadKey();
        }

        static int NumTabuada()
        {
            int num;
            while (true)
            {
                Console.Write("Qual o número você quer na tabuada? ");
                if (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
                {
                    Console.WriteLine("Digite um valor válido.\n(Pressione qualquer tecla para continuar)");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }
            return num;
        }

        static void Tabuada(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                int conta = num * i;
                Console.WriteLine($"{num} * {i} = {conta}");
            }
        }
    }
}
