using System;

namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            while (true)
            {
                Console.Write("Digite os valores de X e Y: ");
                string[] valores = Console.ReadLine()!.Split(' ');

                if (valores.Length != 2 ||
                    !int.TryParse(valores[0], out X) ||
                    !int.TryParse(valores[1], out Y))
                {
                    Console.WriteLine("Entrada inválida, tente de novo.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                if (X == 0 || Y == 0) 
                {
                    Console.WriteLine("Finalizando o programa...");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                Console.WriteLine(Quadrante(X, Y));
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static string Quadrante(int X, int Y)
        {
            if (X > 0 && Y > 0)
                return "Primeiro";
            else if (X < 0 && Y > 0)
                return "Segundo";
            else if (X < 0 && Y < 0)
                return "Terceiro";
            else if (X > 0 && Y < 0)
                return "Quarto";
            else
                return ""; // Caso não caia em nenhum, segurança
        }
    }
}
