using Course.Entities;
using Course.Services;
using System;
using System.Globalization;

namespace Course
{
    internal class ProgramPredicateBoolean
    {
        static void Mainw(string[] args)
        {
            List<ProductPredicate> list = new List<ProductPredicate>();

            list.Add(new ProductPredicate("Tv", 900.00));
            list.Add(new ProductPredicate("Mouse", 50.00));
            list.Add(new ProductPredicate("Tablet", 350.50));
            list.Add(new ProductPredicate("HD Case", 80.90));

            list.RemoveAll(ProductTest);
            foreach (ProductPredicate p in list)
            {
                Console.WriteLine(p);
            }

        } 
        public static bool ProductTest(ProductPredicate p)
        {
            return p.Price >= 100.0;
        }
    }
}
