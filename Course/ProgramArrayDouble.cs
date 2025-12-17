using System;
using System.Linq;

namespace Course
{
    class ProgramArrayDouble
    {
        static void Mains(string[] args)
        {
            double[] entrada = Console.ReadLine()
                                      .Split(' ')
                                      .Select(double.Parse)
                                      .ToArray();

            ProgramArrayDouble p = new ProgramArrayDouble();
            double media = p.calcularMedia(entrada);

            Console.WriteLine($"MEDIA = {media:F1}");
        }

        public double calcularMedia(double[] nums)
        {
            double total = 0;
            int validos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0 || nums[i] > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    total += nums[i];
                    validos++;
                }
            }

            return validos > 0 ? total / validos : 0;
        }
    }
}
