using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    internal class ProgramLINQSQLExercise
    {
        static void MainEXQ(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<ProductLINSQL> list = new List<ProductLINSQL>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new ProductLINSQL(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
