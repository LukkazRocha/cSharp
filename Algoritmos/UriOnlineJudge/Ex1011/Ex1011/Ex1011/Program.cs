namespace Ex1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());

            double volume = 4.0 * 3.14159 * Math.Pow(raio, 3) / 3;

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
        }
    }
}