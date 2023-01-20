using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, x, y, c, d;
            double a, b, B, h, area, resultado;

            x = 5;
            y = 2 * x;
            b = 6.0;
            B = 8.0;
            h = 5.0;
            c = 5;
            d = 2;
            a = 5.0;
            A = (int) a;

            resultado = (double) c / d;

            area = (b + B) / 2.0 * h;

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine();
            Console.WriteLine(area);
            Console.WriteLine(resultado);
            Console.WriteLine(A);

            Console.ReadLine();
        }
    }
}