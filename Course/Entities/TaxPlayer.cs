using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal abstract class TaxPlayer
    {
        public string Name { get; set; }
        public double AnualInCome { get; set; }

        public TaxPlayer()
        {

        }
        protected TaxPlayer(string name, double anualInCome) 
        {
            Name = name;
            AnualInCome = anualInCome;
        }
        public abstract double Tax();
    }
}
