using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    internal class PessoaDesconstructor
    {
        public string Nome { get; set; }
        public string sobreNome { get; set; }

        public PessoaDesconstructor()
        {

        }

        public PessoaDesconstructor(string nome, string sobrenome)
        {
            Nome = nome;
            sobreNome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = sobreNome;
        }
    }
}
