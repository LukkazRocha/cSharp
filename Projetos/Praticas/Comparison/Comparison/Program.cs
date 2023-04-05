using Comparison.Entities;
using System;

namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>
            {
                new Product("TV", 900.00),
                new Product("Notebook", 1200.00),
                new Product("Tablet", 450.00)
            };

            // Expressão lambda
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            // Lambda diretamente no argumento
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            // Também pode ser passado como referência ao inves de chamar a função diretamente.
            // EXEMPLO

            //Comparison<Product> comp = CompareProducts;

            //list.Sort(comp);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // EXEMPLO sem utilizar lambda
        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}