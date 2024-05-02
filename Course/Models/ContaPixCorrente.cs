using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    internal class ContaPixCorrente : ContaPix
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        } 
    }
}
