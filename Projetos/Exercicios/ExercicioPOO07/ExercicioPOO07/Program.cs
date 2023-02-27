using System;
using System.Globalization;

namespace ExercicioPOO07 // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria conta;
            double quanti;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposito);
            } else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            quanti = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(quanti);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quanti = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(quanti);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}