using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class ProgramCalculadora
    {
        static void MainC(string[] args)
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("###### Calculadora de IMC ######");
            Console.WriteLine("________________________________");

            Console.Write("Digita a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("________________________________");

            Console.Write("Você é Homem ou Mulher? ");
            string sexo = Console.ReadLine();

            Console.WriteLine("________________________________");

            Console.Write("Qual sua altura? (ex.: 1.70): ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("________________________________");

            Console.Write("Qual seu peso? (ex.: 64.3): ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("________________________________");
            Console.WriteLine(CalcularIMC(peso, altura));

        }

        static string CalcularIMC(double peso, double altura)
        {
            double IMC = peso / (altura * altura);

            if (IMC < 18.5)
            {
                return $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está Abaixo do Peso.";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                return $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com o Peso Normal.";
            }
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                return $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com Sobrepeso.";
            }
            else
            {
                return $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com Obesidade.";
            }
        }
    }
}
