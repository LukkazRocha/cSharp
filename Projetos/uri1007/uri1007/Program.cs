using System;

namespace uri1007 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}