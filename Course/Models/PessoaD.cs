using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    internal class PessoaD
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public PessoaD(string nome)
        {
            Nome = nome;
        }

        public virtual void Apresentar() //Polimorfismo (virtual), assim posso acessar o Apresentar() em outras classes que estão fazendo herança, através do método (public override).
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}
