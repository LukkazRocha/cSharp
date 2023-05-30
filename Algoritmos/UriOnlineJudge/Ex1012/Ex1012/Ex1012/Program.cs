namespace Ex1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);

            double triangulo = A * C / 2.0;
            double circulo = Math.Pow(C, 2.0) * 3.14159;
            double trapezio = (A + B) / 2.0 * C;
            double quadrado = Math.Pow(B, 2.0);
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
        }
    }
}