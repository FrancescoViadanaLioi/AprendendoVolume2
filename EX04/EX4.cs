using System;
using System.Globalization;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0, impostoRenda = 0;

            Console.Write("Digite seu salário: R$");
            bool sucess = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out salario);

            if(!sucess || salario < 0)
            {
                Console.WriteLine("Favor digitar um salário válido e positivo.");
                return;
            }
            else if (salario >= 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("ISENTO DE IR");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                impostoRenda = salario * 0.08;
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                impostoRenda = salario * 0.18;
            }
            else if (salario > 4500.00)
            {
                impostoRenda = salario * 0.28;
            }
            Console.WriteLine($"O seu imposto de renda será de R${impostoRenda.ToString("F2",CultureInfo.InvariantCulture)}.");
            
            Console.ReadLine();
        }
    }
}