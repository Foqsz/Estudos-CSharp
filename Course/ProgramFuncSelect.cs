using Course.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Course
{
    internal class ProgramFuncSelect
    {
        static void MainFS(string[] args)
        {
            List<ProductPredicate> list = new List<ProductPredicate>();

            list.Add(new ProductPredicate("Tv", 900.00));
            list.Add(new ProductPredicate("Mouse", 50.00));
            list.Add(new ProductPredicate("Tablet", 350.50));
            list.Add(new ProductPredicate("HD Case", 80.90));

            Func<ProductPredicate, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
