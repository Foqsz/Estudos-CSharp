using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    internal class PessoaEscola
    {
        public string Nome { get; set; }
        public List<PessoaEscola> Alunos { get; set; }

        public void AdicionarAluno(PessoaEscola pessoa)
        {
            Alunos.Add(pessoa);
        }

        public int ObterQuantidadeDeAlunos()
        {
            int quant = Alunos.Count;
            return quant;
        }

        public bool RemoverAluno(PessoaEscola pessoa)
        {
            return Alunos.Remove(pessoa);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "N° " + count + " " + Nome;
                Console.WriteLine(texto);
            }
        }
    }
}
