using System;
using System.Globalization;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'S' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numeroConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantidade);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantidade);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
