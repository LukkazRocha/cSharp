using System;

namespace uri1016 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double min = number * 2;

            Console.WriteLine(min + " minutos");
        }
    }
}