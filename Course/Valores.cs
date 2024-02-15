using System;
using System.Globalization;

namespace Course
{
    internal class Valores
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
        public override string ToString()
        {
            double perimetro = Perimetro();
            double diagonal = Diagonal();
            return "Area: " + Largura * Altura + ", Perimetro: " + perimetro.ToString("F2", CultureInfo.InvariantCulture) + " Diagonal: " + diagonal.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

