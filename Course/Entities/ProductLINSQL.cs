namespace Course.Entities
{
    internal class ProductLINSQL
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public ProductLINSQL(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
