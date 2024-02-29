using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class ClientExercise
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public List<ProductExercise> Quantity { get; set; } = new List<ProductExercise>();

        public ClientExercise()
        {

        }

        public ClientExercise(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (ProductExercise orderC in Quantity)
            {
                sum += orderC.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + OrderStatusEx.Processing);
            sb.AppendLine("Client: " + Name);
            sb.AppendLine("Order items:");

            foreach (ProductExercise orderC in Quantity)
            {
                sb.AppendLine(orderC.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        } 
    }
}
