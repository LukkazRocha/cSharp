using System;
using System.Globalization;

namespace ExercicioPOO03 // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Retangulo ret = new Retangulo();


            Console.WriteLine("Entra a largura e altura do retângulo");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = ret.Area();
            double perimetro = ret.Perimetro();
            double diagonal = ret.Diagonal();

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}