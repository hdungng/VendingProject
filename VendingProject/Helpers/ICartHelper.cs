using VendingProject.Models.Domain;

namespace VendingProject.Helpers
{
    public interface ICartHelper
    {
        string GetCartJson();

        List<CartItem> GetCartItems(string cartJSON);

        void ParseCartToJson(List<CartItem> cartsDomain);
    }
}
