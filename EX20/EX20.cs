using System;

namespace EX20
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = LerInteiroValido("Digite um número para atribuir a x: ");
            int y = LerInteiroValido("Digite um número para atribuir a y: ");
            int resultfinal = VerificarEContinuar(x, y);
            Console.WriteLine($"A soma dos ímpares entre {x} e {y} é de {resultfinal}");
            Console.ReadKey();
        }
        static int LerInteiroValido(string mensagem)
        {
            while (true)
            {
                int resultado;
                Console.Write(mensagem);
                if (!int.TryParse(Console.ReadLine(), out resultado))
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                    LimparEContinuar();
                    continue;
                }
                return resultado;
            }
        }
        static void LimparEContinuar()
        {
            Console.WriteLine("Pressione Qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
        static int VerificarEContinuar(int x, int y)
        {
            int max, min, soma = 0;

            if (x < y)
            {
                max = y;
                min = x;
            }
            else
            {
                max = x;
                min = y;
            }
            for(int i = min+1; i < max; i++)
            {
                if (i % 2 != 0) soma += i;
            }
            return soma;
        }

    }
}