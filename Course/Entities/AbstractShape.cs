using Course.Entities.Enums;
using Course.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Cor Cor { get; set; }

        public abstract double Area();
    }
}
