using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
           int X = 0;
            while (X < 5)
            {
                int Y = X * 3;
                Console.Write($"{Y} ");
                X += 1;
            }
            Console.WriteLine("\nFIM");
        }
    }
}