using System;

namespace Miscelania
{
    public class Limpar
    {
        public static void LimparTela()
        {
            Console.WriteLine("Valor inv�lido, tente de novo.");
            Console.WriteLine("(PRESSIONE QUALQUER TECLA PARA CONTINUAR)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}