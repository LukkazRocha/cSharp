using System;

namespace uri1001 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int X = A + B;

            Console.WriteLine("X = " + X);
        }
    }
}