using System;

namespace Miscelania
{
    public class Limpar
    {
        public static void LimparTela()
        {
            Console.WriteLine("Entrada inv�lida, tente de novo.");
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}