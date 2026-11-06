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
            const double IMC_AbaixoDoPeso = 18.5;
            const double IMC_Normal = 24.9;
            const double IMC_Sobrepeso = 29.9;
            const double IMC_Obesidade = 30.0;

            if (IMC < IMC_AbaixoDoPeso)
            {
                return $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está Abaixo do Peso.";
            }
            else if (IMC >= IMC_AbaixoDoPeso && IMC <= IMC_Normal)
            {
                return $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com o Peso Normal.";
            }
            else if (IMC >= IMC_Normal && IMC <= IMC_Sobrepeso)
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
