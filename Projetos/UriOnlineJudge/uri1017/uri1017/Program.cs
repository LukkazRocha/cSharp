using System;

namespace uri1017 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double auto = 12;
            int tempoViagem = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double media = tempoViagem * velocidade / auto;

            Console.WriteLine(media.ToString("F3"));

        }
    }
}