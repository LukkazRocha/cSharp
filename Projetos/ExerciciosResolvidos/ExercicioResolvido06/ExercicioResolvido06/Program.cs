using System;
using System.Globalization;

namespace ExercicioResolvido06 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont = 0;            
            soma = 0.0;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (idade < 0)
            {
                Console.WriteLine("Impossivel calcular");
            } else
            {
                while (idade >= 0)
                {
                    soma += idade;
                    cont++;
                    idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }            
        }
    }
}