namespace Course.Entities
{
    internal class ProductXY
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductXY(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is ProductXY)) 
            {
                return false;
            }
            ProductXY other = obj as ProductXY; 
            return Name.Equals(other.Name) && Price.Equals(other.Price);    
        }
    }
}
