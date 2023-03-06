using EnumExemple.Entities.Enum;
using System;

namespace EnumExemple // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(os);
        }
    }
}