using System;

namespace Miscelania
{
    public static class LimparTela // Classe criada para limpar a tela em caso de erro
    {
        public static void Executar()
        {
            Console.WriteLine("Entrada inv�lida, tente novamente.\n(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}