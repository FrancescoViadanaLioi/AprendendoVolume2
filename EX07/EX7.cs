using System;

namespace EX07
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 10;
            Console.WriteLine("Olá\n");
            
            while(x<y)
            {
                Console.WriteLine($"X = {x} \nY = {y}\n");
                x *= 2;
                y += 1;
            }
            Console.ReadLine();
            }
        }
    }