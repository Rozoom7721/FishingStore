namespace Fishing_Store.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
