using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    internal class Teatcher : PessoaD
    {
        public decimal Salario { get; set; }


        public Teatcher(string nome) : base(nome)
        { 
        } 
        public override void Apresentar()
        {
            Console.WriteLine($"Sou o professor {Nome}, tenho {Idade} anos. Meu sálario atualmente é de R${Salario}. ");
        }
    }
}
