namespace VendingProject.Models.Domain
{
    public class CartItem
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public int SubTotal { get; set; }
    }
}
