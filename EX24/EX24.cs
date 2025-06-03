using System;

namespace EX24
{
    class Program
    {
        static void Main(string[] args)
        {
            Validacao validador = new Validacao();
            int n = validador.QntdElem();
            int[] vetor = validador.Loop(n);
            validador.MostrarNumeros(vetor);
            Console.ReadKey();
        }
    }
}