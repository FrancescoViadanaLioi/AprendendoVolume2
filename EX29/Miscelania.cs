using System;

namespace Miscelania
{
    public class Limpar
    {
        public static void LimparTela()
        {
            Console.WriteLine("Valor inv�lido, tente novamente.");
            Console.WriteLine("(Pressione Qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}