using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Aprendizagem
    {
        public int yes { get; private set; }
        public double yes1 { get; private set; }
        public string yes3 { get; set; }

        public Aprendizagem(int yes, double yes1)
        {
            yes = yes;
            yes1 = yes1;
        }
        public Aprendizagem(int yes, double yes1, string yes3) : this(yes, yes1)
        {
            yes3 = yes3;
        }
    }
}
