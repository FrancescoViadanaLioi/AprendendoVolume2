using System;

namespace EX15
{
    class Program
    {
        // Variáveis estáticas para armazenar os votos
        static int gasolina = 0, alcool = 0, diesel = 0;

        static void Main(string[] args)
        {
            // Loop principal que mantém o programa rodando até o usuário decidir sair
            while (true)
            {
                MostrarMenu();          // Exibe o menu de opções
                int escolha = LerEscolha(); // Lê e valida a escolha do usuário

                if (escolha == 4)       // Se a escolha for 4, sai do programa
                {
                    MostrarResultado(); // Exibe os resultados finais
                    break;              // Sai do loop e finaliza o programa
                }
                ProcessarEscolha(escolha);  // Processa a escolha do usuário e incrementa os votos
            }
        }

        // Método para exibir o menu de opções ao usuário
        static void MostrarMenu()
        {
            Console.WriteLine("-------------Pesquisa do Posto-------------");
            Console.WriteLine("1 - Gasolina\n2 - Álcool\n3 - Diesel\n4 - Sair");
            Console.Write("Digite o que você mais utiliza para a nossa pesquisa: ");
        }

        // Método para ler e validar a escolha do usuário
        static int LerEscolha()
        {
            int escolha;
            // Enquanto a entrada não for válida, solicita nova entrada
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 4)
            {
                Console.WriteLine("INSIRA UM VALOR VÁLIDO! (Pressione qualquer tecla para continuar)");
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
            }
            return escolha; // Retorna a escolha válida
        }

        // Método para processar a escolha do usuário e incrementar o voto correspondente
        static void ProcessarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    gasolina++;
                    break;
                case 2:
                    alcool++;
                    break;
                case 3:
                    diesel++;
                    break;
            }
            Console.WriteLine("OBRIGADO PELA PRESENÇA (Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }

        // Método para exibir o resultado final da pesquisa
        static void MostrarResultado()
        {
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Gasolina: {gasolina}\nÁlcool: {alcool}\nDiesel: {diesel}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
