using System;
using System.Globalization;

namespace uri1014 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            double consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3") + " km/l");

        }
    }
}