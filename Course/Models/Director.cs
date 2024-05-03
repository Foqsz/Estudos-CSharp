using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    internal class Director : Teatcher
    {
        public Director(string nome) : base(nome)
        {
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }
    }
}
