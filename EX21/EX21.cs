using System;
using System.Globalization;

namespace EX21
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double tempC = TempEmCelsius();
                double tempF = TempEmFahrenheit(tempC);
                Console.WriteLine($"A temperatura de {tempC.ToString("F2", CultureInfo.InvariantCulture)}°C é igual a {tempF.ToString("F2", CultureInfo.InvariantCulture)}°F");

                string resposta = SorN();
                if (resposta == "N") break;
                Console.Clear();
            }
            Console.WriteLine("Programa encerrado.");
            Console.ReadKey();
        }
        static double TempEmCelsius()
        {
            while (true)
            {
                Console.Write("Digite uma temperatura em Celsius: ");
                bool sucesso = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double celsius);

                if (sucesso) return celsius;

                Console.WriteLine("Valor inválido. Pressione qualquer tecla para tentar novamente.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static double TempEmFahrenheit(double c) => (9 * c) / 5 + 32;

        static string SorN()
        {
           while (true)
            {
                Console.Write("Você deseja prosseguir?(S/N): ");
                string escolha = Console.ReadLine();
                if (escolha.Equals("S", StringComparison.OrdinalIgnoreCase)) return "S";

                if (escolha.Equals("N", StringComparison.OrdinalIgnoreCase)) return "N";

                Console.WriteLine("Entrada inválida, digite somente S ou N.\n(Pressione qualquer tecla para continuar)");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}