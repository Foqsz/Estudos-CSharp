using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class LegalPerson : TaxPlayer
    {
        public double HealthExpenditures { get; set; }

        public LegalPerson()
        {
        }
        public LegalPerson(string name, double anualInCome, double healthExpenditures) : base(name, anualInCome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualInCome < 20000.0)
            {
                return AnualInCome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualInCome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
