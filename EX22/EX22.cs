using System;

namespace EX22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ValidEntrada();
            Loop(n);
            Console.ReadKey();
        }
        static int ValidEntrada()
        {
            int n;

            while (true)
            {
                Console.Write("Insira o número de repetições que o loop terá: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0) return n;
                LimparEContinuar();
            }
        }
        static void Loop(int n)
        {
            for (int i = 0; i < n; i++)
            {
                (int x, int y) = ValidLoop();
                int somaIntervalo = SomarImparesEntreXeY(x, y);
                Console.WriteLine($"A soma dos ímpares entre o intervalo {x} e {y} é de {somaIntervalo}.");
            }
        }
        static (int x, int y) ValidLoop()
        {
            while (true)
            {
                Console.Write("Quais são os dois números? ");
                string[] vect = Console.ReadLine()!.Split(' ');
                if (vect.Length == 2 && int.TryParse(vect[0], out int x) && int.TryParse(vect[1], out int y))
                {
                    return (x, y);
                }
                LimparEContinuar();
            }
        }
        static int SomarImparesEntreXeY(int x, int y)
        {
            int soma = 0;
            int comeco = Math.Min(x, y);
            int fim = Math.Max(x, y);

            for (int i = comeco + 1; i <= fim; i++)
            {
                if (i % 2 != 0) soma += i;
            }
            return soma;
        }
        static void LimparEContinuar()
        {
            Console.WriteLine("Entrada inválida, tente de novo.\n(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}