using System;
using System.Globalization;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;

            Console.Write("Me dê o lado 1: ");
            bool sucesso1 = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out n1);

            Console.Write("Me dê o lado 2: ");
            bool sucesso2 = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out n2);

            Console.Write("Me dê o lado 3: ");
            bool sucesso3 = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out n3);

            if (!sucesso1 || !sucesso2 || !sucesso3 || n1 <= 0 || n2 <= 0 || n3 <= 0)
            {
                Console.WriteLine("Favor digitar números válidos e positivos.");
                Console.ReadLine();
                return;
            }

            // Garantir que A seja o maior lado
            double A, B, C;
            if (n1 >= n2 && n1 >= n3)
            {
                A = n1;
                B = n2;
                C = n3;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                A = n2;
                B = n1;
                C = n3;
            }
            else
            {
                A = n3;
                B = n1;
                C = n2;
            }

            if (A >= B + C)
            {
                Console.WriteLine("NÃO FORMA TRIÂNGULO!");
                Console.ReadLine();
                return;
            }

            // Tipos de triângulo por ângulo
            if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIÂNGULO RETÂNGULO");
            }
            else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIÂNGULO OBTUSÂNGULO");
            }
            else
            {
                Console.WriteLine("TRIÂNGULO ACUTÂNGULO");
            }

            // Tipos de triângulo por lados
            if (n1 == n2 && n2 == n3)
            {
                Console.WriteLine("TRIÂNGULO EQUILÁTERO");
            }
            else if (n1 == n2 || n2 == n3 || n1 == n3)
            {
                Console.WriteLine("TRIÂNGULO ISÓSCELES");
            }

            Console.ReadLine(); // Mantém o console aberto
        }
    }
}
