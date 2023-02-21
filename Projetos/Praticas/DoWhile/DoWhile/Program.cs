using System;
using System.Globalization;

namespace DoWhile // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            char resp;

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius");
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                f = 9.0 * c / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1", CultureInfo.InvariantCulture));

                Console.WriteLine("Deseja repetir (s/n)?");
                resp = char.Parse(Console.ReadLine());
            } while (resp == 's');
        }
    }
}