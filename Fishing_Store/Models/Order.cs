using System;
using System.Security.Cryptography.Xml;

namespace Fishing_Store.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
