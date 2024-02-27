using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Aprendizagem
    {
        public string Cliente { get; set; }
        public string Lista { get; set; }
        public int CompraA { get; private set; } 
        public Aprendizagem()
        {
        }

        public Aprendizagem(string cliente, int compraA)
        {
            Cliente = cliente;
            CompraA = compraA;
        }

        public Aprendizagem(string cliente, int compraA, string lista) : this(cliente, compraA)
        { 
            Lista = lista;
        }
         

        public override string ToString()
        {
            return Lista
            + " Você comprou, "
            + CompraA
            + " Obrigado e volte sempre.";
        }
    }
}
