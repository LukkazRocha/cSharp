using System;

namespace Matrizes // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {


            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));
        }
    }
}