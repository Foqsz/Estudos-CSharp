using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle(double witdh, double height, Color color) : base(color)
        {
            Width = witdh;
            Heigth = height;
        }
        public override double Area()
        {
            return Width * Heigth;
        }
    }
}
