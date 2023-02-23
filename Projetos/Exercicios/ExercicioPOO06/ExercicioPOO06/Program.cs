using System;
using System.Globalization;

namespace ExercicioPOO06 // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação em dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorEmReais = ConversorMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + valorEmReais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}