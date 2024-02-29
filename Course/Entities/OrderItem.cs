using Course.Entities.Enums;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;

namespace Course.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public List<ProductExercise> Item { get; set; } = new List<ProductExercise>();

        public OrderItem()
        {

        }
        public OrderItem(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }
}
