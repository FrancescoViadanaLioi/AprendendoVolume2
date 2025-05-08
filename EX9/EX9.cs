using System;

namespace EX9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;

            Valoresi valoresi = new Valoresi();
            valoresi.ImprimirValoresI(x);

            Valoresy valoresy = new Valoresy();
            valoresy.ImprimirValoresY(x);

            Console.ReadLine();
        }
    }

    public class Valoresi
    {
        public void ImprimirValoresI(int x)
        {
            int i = 0;
            Console.WriteLine("Valores de i:");
            while (i < x)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }

    public class Valoresy
    {
        public void ImprimirValoresY(int x)
        {
            int i = 0;
            int y = 0;
            Console.WriteLine("Valores de y:");
            while (i < x)
            {
                y += i;
                Console.WriteLine(y);
                i++;
            }
        }
    }
}
