namespace Ex1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(vet1[0]);
            double y1 = double.Parse(vet1[1]);
            double x2 = double.Parse(vet2[0]);
            double y2 = double.Parse(vet2[1]);

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}