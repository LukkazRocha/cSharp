using InterfaceComAbstract.Model.Entities;
using InterfaceComAbstract.Model.Enums;

using System;
using System.Globalization;

namespace InterfaceComAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do círculo:");
            Console.Write("Cor (White/Black): ");
            Color colorCircle = Enum.Parse<Color>(Console.ReadLine());
            Console.Write("Raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            IShape s1 = new Circle(radius, colorCircle);

            Console.WriteLine("Dados do retângulo:");
            Console.Write("Cor (White/Black): ");
            Color colorRectangle = Enum.Parse<Color>(Console.ReadLine());
            Console.Write("Largura: ");
            double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            IShape s2 = new Rectangle(width, height, colorRectangle);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}