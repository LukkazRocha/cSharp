namespace Ex1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());

            double total = vendas * 0.15 + salario;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
        }
    }
}