using System;

namespace EX8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4, y = 0, i = 0;

            while(i<x)
            {
                i += 1;
                y += i;
                Console.Write($"{i} ");
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}