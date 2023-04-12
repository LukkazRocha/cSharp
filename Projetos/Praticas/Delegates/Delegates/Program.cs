using Delegates.Services;
using System;

namespace Delegates
{
    internal class Program
    {

        delegate double BynaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BynaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}