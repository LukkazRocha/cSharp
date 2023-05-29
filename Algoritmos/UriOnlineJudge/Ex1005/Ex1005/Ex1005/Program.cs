namespace Ex1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double MEDIA = (A * 3.5 + B * 7.5) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
        }
    }
}