using System;
using System.Globalization;

namespace Course.Entities
{
    internal class ProductGeneric : IComparable //Após adicionar o IComparable, criar a interface
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductGeneric(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is ProductGeneric))
            {
                throw new ArgumentException("Comparing erro: argument is not a Product");
            }
            ProductGeneric other = obj as ProductGeneric;
            return Price.CompareTo(other.Price);
        }
    }
}
