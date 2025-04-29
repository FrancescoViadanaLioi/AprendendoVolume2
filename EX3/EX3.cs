using System;
using System.Globalization;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            int HoraInicial = 0, MinutoInicial = 0, HoraFinal = 0, MinutoFinal = 0;
            int DH = 0, DM = 0;

            Console.Write("Digite a hora e o minuto de início do Evento separados por espaço: ");
            string[] entradaInicial = Console.ReadLine()!.Split(' ');
            
            // Captura de Hora e Minuto inicial
            if (entradaInicial.Length != 2 || !int.TryParse(entradaInicial[0], out HoraInicial) || !int.TryParse(entradaInicial[1], out MinutoInicial) || HoraInicial < 0 || HoraInicial > 23 || MinutoInicial < 0 || MinutoInicial > 59)
            {
                Console.WriteLine("Hora ou minuto inválido!");
                return;
            }

            Console.Write("Digite a hora e o minuto de fim do evento separados por espaço: ");
            string[] entradaFinal = Console.ReadLine()!.Split(' ');

            // Captura de Hora e Minuto final
            if (entradaFinal.Length != 2 || !int.TryParse(entradaFinal[0], out HoraFinal) || !int.TryParse(entradaFinal[1], out MinutoFinal) || HoraFinal < 0 || HoraFinal > 23 || MinutoFinal < 0 || MinutoFinal > 59)
            {
                Console.WriteLine("Hora ou minuto inválido!");
                return;
            }

            // Cálculo da duração
            DH = HoraFinal - HoraInicial;
            DM = MinutoFinal - MinutoInicial;

            if (DM < 0)
            {
                DM += 60;
                DH -= 1;
            }

            if (DH < 0)
            {
                DH += 24; // Ajusta para eventos que cruzam meia-noite
            }

            Console.WriteLine($"O evento durou {DH} horas e {DM} minutos.");
        }
    }
}
