using System;

namespace Miscelania
{
    public static class LimparTela // Classe utilit�ria que exibe uma mensagem de erro e limpa a tela ap�s pressionar uma tecla
    {
        public static void Executar()
        {
            Console.WriteLine("Entrada inv�lida, tente novamente.\n(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}