using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberFunc = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double salaryForHour = double.Parse(Console.ReadLine());

            double fullSalary = hours * salaryForHour;

            Console.WriteLine("NUMBER = " + numberFunc);
            Console.WriteLine("SALARY = U$ " + fullSalary.ToString("F2"));            

        }
    }
}