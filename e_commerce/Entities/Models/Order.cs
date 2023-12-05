namespace Entities.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();

        public User user { get; set; } = new();
        public bool Shipped { get; set; }
        public DateTime OrderedAt { get; set; } = DateTime.Now;

    }
}