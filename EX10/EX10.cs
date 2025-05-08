using System;

namespace EX10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            // Primeira leitura dos números
            Console.Write("Digite dois números inteiros para avaliação de ordem (separados por espaço): ");
            string[] vet = Console.ReadLine()!.Split(' ');

            // Validação da entrada
            if (vet.Length != 2 || !int.TryParse(vet[0], out x) || !int.TryParse(vet[1], out y))
            {
                Console.WriteLine("VALOR INVÁLIDO! FAVOR REDIGITAR");
                return;
            }

            // Loop para comparar os números até que sejam iguais
            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("ORDEM CRESCENTE");
                }
                else if (x > y)
                {
                    Console.WriteLine("ORDEM DECRESCENTE");
                }

                // Solicita novos números
                Console.Write("Digite novamente dois números inteiros (separados por espaço): ");
                vet = Console.ReadLine()!.Split(' ');

                // Validação da nova entrada
                if (vet.Length != 2 || !int.TryParse(vet[0], out x) || !int.TryParse(vet[1], out y))
                {
                    Console.WriteLine("VALOR INVÁLIDO! FAVOR REDIGITAR");
                    return;
                }
            }

            // Quando x e y forem iguais
            Console.WriteLine("NÚMEROS IGUAIS! FIM.");
            Console.ReadLine();
        }
    }
}
