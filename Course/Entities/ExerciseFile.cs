namespace Course.Entities
{
    class ExerciseFile
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public ExerciseFile(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
    }
}