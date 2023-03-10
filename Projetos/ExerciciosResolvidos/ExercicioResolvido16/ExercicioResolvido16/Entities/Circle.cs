using ExercicioResolvido16.Entities.Enums;

namespace ExercicioResolvido16.Entities
{
    internal class Circle : Shape
    {
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Radius { get; set; }


    }
}
