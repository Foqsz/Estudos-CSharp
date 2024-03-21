using System;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
    internal class ProgramGeneric
    {
        static void Mainss(string[] args)
        {
            List<ProductGeneric> list = new List<ProductGeneric>(); //lista de numeros inteiros e instanciando lista vazia
                
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture); 
                list.Add(new ProductGeneric(name, price)); //Ler o valor x e adiciona na lista
            }

            CalculationService calculationService = new CalculationService(); //instanciando o CalculationService

            ProductGeneric max = calculationService.Max(list); //Aqui chama a função max e passa a lista como argumento, o resultado da função calculationservice vai pra variavel Max

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}
