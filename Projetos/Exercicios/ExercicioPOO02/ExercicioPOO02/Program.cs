using System;
using System.Globalization;

namespace ExercicioPOO02 // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salary + f2.Salary) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}