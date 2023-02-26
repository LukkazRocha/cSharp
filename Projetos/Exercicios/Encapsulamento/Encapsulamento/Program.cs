using System;

namespace Encapsulamento // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {



            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p);

            
        }
    }
}