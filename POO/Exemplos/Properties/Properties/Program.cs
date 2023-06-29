namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Produto("TV", 500, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}