namespace BookstoreAPI.Models
{
    public enum OrderStatus
    {
        PENDING,
        COMPLETED,
        CANCELLED
    }

    public class Order
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; } = OrderStatus.PENDING;

    }
}
