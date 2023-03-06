using System;
using System.Globalization;
using Teste.Entities.Enum;

namespace Teste // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string diaDaSemanaStr = "Segunda";
            DiasDaSemana diaDaSemana = (DiasDaSemana)Enum.Parse(typeof(DiasDaSemana), diaDaSemanaStr);

        }
    }
}
