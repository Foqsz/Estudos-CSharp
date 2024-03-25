using Course.Entities;
using Course.Services;
using System;
using System.Globalization;

namespace Course
{ 
    internal class ProgramActionForEach
    {
        static void MainAF(string[] args)
        {
            List<ProductPredicate> list = new List<ProductPredicate>();

            list.Add(new ProductPredicate("Tv", 900.00));
            list.Add(new ProductPredicate("Mouse", 50.00));
            list.Add(new ProductPredicate("Tablet", 350.50));
            list.Add(new ProductPredicate("HD Case", 80.90));

            list.ForEach(p => { p.Price += p.Price * 0.1; }); 
            foreach (ProductPredicate p in list)
            {
                Console.WriteLine(p);
            }
        }  
    }
}
