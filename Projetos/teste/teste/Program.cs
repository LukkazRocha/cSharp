using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            Console.WriteLine("Bom dia!");

            if (x > 0)
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");
        }
    }
}