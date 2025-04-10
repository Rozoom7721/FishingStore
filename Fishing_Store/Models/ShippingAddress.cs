namespace Fishing_Store.Models
{
    public class ShippingAddress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public int CustomerUd { get; set; }
        public Customer Customer { get; set; }
    }
}
