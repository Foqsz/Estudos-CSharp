using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Interfaces
{
    internal interface ICalculatorPix
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2); //Metodos sem corpo são obrigatorios.
        int Dividir(int num1, int num2) //Metodos que tem corpo não são obrigatorios, são opcionais.
        {
            return num1 / num2;
        }
    }
}
