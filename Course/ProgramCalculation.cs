using Course.Entities;
using Course.Services;
using System;
using System.Globalization;

namespace Course
{
    delegate void BinaryNumaricOperationx(double n1, double n2);
    internal class ProgramCalculation
    {
        static void MainCq(string[] args)
        {
            double a = 10;
            double b = 12; 

            BinaryNumaricOperationx op = CalculationDelegate.ShowSum;
            op += CalculationDelegate.ShowMax;

            op.Invoke(a, b); 
        } 
    }
}
