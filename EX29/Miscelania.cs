using System;

namespace Miscelania
{
    public class Limpar
    {
        public static void LimparTela()
        {
            Console.WriteLine("Valor inválido, tente novamente.");
            Console.WriteLine("(Pressione Qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}