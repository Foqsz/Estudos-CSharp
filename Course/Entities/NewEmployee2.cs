using System;
using System.Globalization;

namespace Course.Entities
{
    internal class NewEmployee2 : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public NewEmployee2(string csvNewEmployee2)
        {
            string[] vect = csvNewEmployee2.Split(',');
            Name = vect[0]; 
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        } 
        public override string ToString()
        {
            return Name + " " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is NewEmployee2))
            {
                throw new ArgumentException("Comparing error: argument is not an employee");
            }
            NewEmployee2 other = obj as NewEmployee2;
            return Name.CompareTo(other.Name);
        }
    }
}
