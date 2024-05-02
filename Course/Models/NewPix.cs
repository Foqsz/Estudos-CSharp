using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    internal class NewPix
    {
        public NewPix(int numeroPix, decimal saldoInicial)
        {
            NumeroPix = numeroPix;
            saldo = saldoInicial;
        }

        public int NumeroPix { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Você não tem saldo suficiente.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponível é " + saldo);
        }
    }
}
