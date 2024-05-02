using System;
using Course.Models;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaD PessoaP1 = new PessoaD(); //Iniciar um objeto.

            PessoaP1.Nome = "Victor";
            PessoaP1.Idade = 20;
            PessoaP1.Cidade = "Santa Rita";
            PessoaP1.Estado = "Paraíba";

            PessoaP1.Apresentar();
        }
    }
}
