using Course.Models;
using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaDesconstructor p1 = new PessoaDesconstructor("Victor", "Vinicius");

            (string Nome, string sobreNome) = p1;

            Console.WriteLine($"{Nome} {sobreNome}");


        }
    }
}
