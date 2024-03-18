using System;
using System.Globalization;
using Course.Entities; 
using Course.Entities.Enums;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new NewCircle() { Radius = 2.0, Cor = Cor.White };
            IShape s2 = new NewRectangle() { Width = 3.5,  Height = 4.2, Cor = Cor.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
