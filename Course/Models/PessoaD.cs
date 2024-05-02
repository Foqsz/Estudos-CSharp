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
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos. Moro em {Cidade} na {Estado}.");
        }
    }
}
