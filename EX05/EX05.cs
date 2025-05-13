using System;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, soma = 0;

            Console.WriteLine("Digite números inteiros (digite 0 para sair do cálculo):");

            while (true) // Loop controlado com 'break'
            {
                Console.Write("Número: ");
                string entrada = Console.ReadLine();

                // Validação da entrada
                if (!int.TryParse(entrada, out num))
                {
                    Console.WriteLine("Favor digitar um número inteiro válido.");
                    continue; // Volta ao início do loop para redigitar
                }

                if (num == 0) // Condição para sair do loop
                {
                    break; // Sai do loop quando o número é 0
                }

                soma += num; // Soma apenas números válidos
            }

            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
