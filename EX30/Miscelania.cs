using System;

namespace Miscelania
{
    public class Limpar
    {
        public static void LimparTela()
        {
            Console.WriteLine("Valor inválido, tente de novo.");
            Console.WriteLine("(PRESSIONE QUALQUER TECLA PARA CONTINUAR)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}