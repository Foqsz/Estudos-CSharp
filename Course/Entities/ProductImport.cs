using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class ProductImport
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductImport()
        {

        } 
        public ProductImport(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name 
                + " $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
