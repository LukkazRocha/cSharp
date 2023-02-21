using System;
using System.Globalization;

namespace ExercicioResolvido08 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] A;
            double soma, media;

            N = int.Parse(Console.ReadLine());
            A = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            soma = 0.0;
            media = 0.0;
            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                soma += A[i];
            }

            media = soma / N;

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}