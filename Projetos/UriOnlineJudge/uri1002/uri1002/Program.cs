using System;

namespace uri1002 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double A = (Math.Pow(raio, 2) * n);

            Console.WriteLine("A=" + A.ToString("F4"));
        }
    }
}