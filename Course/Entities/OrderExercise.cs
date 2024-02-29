using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using Course.Entities.Enums;

namespace Course.Entities
{
    internal class OrderExercise
    {
        public DateTime Moment { get; set; }
        public OrderStatusEx status { get; set; }
        public List<ProductExercise> Quantitys { get; set; } = new List<ProductExercise>();

        public void AddQuantity(ProductExercise Quantity)
        {
            Quantitys.Add(Quantity);
        }

        public void RemoveQuantity(ProductExercise Quantity)
        {
            Quantitys.Remove(Quantity);
        } 
    }
}
