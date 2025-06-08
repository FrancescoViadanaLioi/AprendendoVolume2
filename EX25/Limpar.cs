using System;

namespace Utilitarios
{

    public class Limpar
    {
        public static void LimparTela()
        {
            Console.WriteLine("Valor inválido, tente de novo.\n(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}