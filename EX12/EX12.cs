using System;

namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0, senhaCorreta = 2002;

            while (senha != senhaCorreta)
            {
                Console.Write("Digite a senha: ");
                if (int.TryParse(Console.ReadLine(), out senha) && senha == senhaCorreta)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Senha inválida, digite novamente. Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Bem vindo ao sistema, meu chapa!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}