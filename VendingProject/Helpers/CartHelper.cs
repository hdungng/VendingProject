using Newtonsoft.Json;
using VendingProject.Models.Domain;

namespace VendingProject.Helpers
{
    public class CartHelper : ICartHelper
    {
        private readonly IHttpContextAccessor contextAccessor;

        public CartHelper(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }
        public string GetCartJson() => contextAccessor.HttpContext.Session.GetString("Cart") == null ?
                JsonConvert.SerializeObject(new List<CartItem>()) :
                contextAccessor.HttpContext.Session.GetString("Cart");


        public List<CartItem> GetCartItems(string cartJSON)
            => JsonConvert.DeserializeObject<List<CartItem>>(cartJSON);


        public void ParseCartToJson(List<CartItem> cartsDomain)
        {
            var cartsString = JsonConvert.SerializeObject(cartsDomain);
            contextAccessor.HttpContext.Session.SetString("Cart", cartsString);
        }
    }
}
