using System;
using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Order
    {
        public int Id { get; set; } // id do pedido
        public DateTime Moment { get; set; } // instante do pedido 
        public OrderStatus Status { get; set; } // status do pedido


        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
