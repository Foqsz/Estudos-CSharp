using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color) //pra ele chamar o construtor da class shape
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; //pi vezes raio ao quadrado
        }
    }
}
