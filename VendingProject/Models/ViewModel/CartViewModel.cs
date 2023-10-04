using VendingProject.Models.Domain;

namespace VendingProject.Models.ViewModel
{
    public class CartViewModel
    {
        public Guid Id { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public int SubTotal { get; set; }
    }
}
