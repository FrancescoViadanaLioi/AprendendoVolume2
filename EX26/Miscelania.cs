using System;

namespace Miscelania
{
    public static class LimparTela // Classe utilitária que exibe uma mensagem de erro e limpa a tela após pressionar uma tecla
    {
        public static void Executar()
        {
            Console.WriteLine("Entrada inválida, tente novamente.\n(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}