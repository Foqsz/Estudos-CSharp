using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    internal class Student : PessoaD
    { 
        public double Nota { get; set; }


        public Student(string nome) : base(nome)
        { 
        } 
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}.");
        }
    }
}
 