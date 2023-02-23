using System;
using System.Globalization;

namespace ExercicioPOO04 // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            
            Funcionario f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f1);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar do salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f1);

        }
    }
}