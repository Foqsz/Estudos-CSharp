using Course.Extensions;
using System;
using System.Linq;

namespace Course
{
    class ProgramExntensions
    {
        static void MainExntesion(string[] args)
        {
            Console.WriteLine("DEMONSTRAÇÃO EXTENSION MEMBERS (C# 14 / .NET 10)");
            Console.WriteLine("\nCriando objeto p : Maria com 20 anos");
            var p = new Pessoa { Name = "Maria", Idade = 20 };

            Console.WriteLine("Metodo de extensão Descibre");
            Console.WriteLine(p.Describe());

            Console.WriteLine("\nPressione algo para continuar");
            Console.ReadKey();

            Console.WriteLine("Membro Estático Associado ao tipo : Default");
            var padrao = Pessoa.Default;

            Console.WriteLine($"Default: {padrao.Describe()}");
            Console.WriteLine("\nPressione algo para finalizar");
            Console.ReadKey();
        }
    }
}
