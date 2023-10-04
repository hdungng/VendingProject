using VendingProject.Models.Domain;

namespace VendingProject.Models.ViewModel
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }

        public List<CartViewModel> CartItems { get; set; }
    }
}
