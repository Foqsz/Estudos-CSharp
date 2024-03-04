using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Course.Entities
{
    internal class PhysicalPerson : TaxPlayer
    {
        public int NumberOfEmployees { get; set; }

        public PhysicalPerson()
        {
        }
        public PhysicalPerson(string name, double anualInCome, int numberOfEmployees) : base(name, anualInCome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualInCome * 0.14;
            }
            else
            {
                return AnualInCome * 0.16;
            }

        }
    }
}