using System;
using System.Globalization;

namespace ExercicioPOO07 // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Conta c;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numeroConta, titular, depositoInicial);                
            } else {                
                c = new Conta(numeroConta, titular);                
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);            
        }
    }
}