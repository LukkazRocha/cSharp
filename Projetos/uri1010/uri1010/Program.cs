using System;

namespace uri1010 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int cod = int.Parse(vet[0]);
            int numberPeaces = int.Parse(vet[1]);
            double price = double.Parse(vet[2]);
            double totalP1 = numberPeaces * price;

            string[] vet2 = Console.ReadLine().Split(' ');

            int cod2 = int.Parse(vet2[0]);
            int numberPeaces2 = int.Parse(vet2[1]);
            double price2 = double.Parse(vet2[2]);
            double totalP2 = numberPeaces2 * price2;

            double total = totalP1 + totalP2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}