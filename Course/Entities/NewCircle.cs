using System;
using System.Globalization;

namespace Course.Entities
{
    internal class NewCircle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle Color = "
            + Cor
            + ", radius = "
            + Radius.ToString("F2", CultureInfo.InvariantCulture)
            + ", area = "
            + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
