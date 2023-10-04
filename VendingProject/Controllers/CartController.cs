using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;
using VendingProject.Helpers;
using VendingProject.Models.Domain;

namespace VendingProject.Controllers
{
    public class CartController : Controller
    {
        private readonly VendingDbContext context;
        private readonly IToastNotification toastNotification;
        private readonly ICartHelper cartHelper;

        public CartController(VendingDbContext dbContext,
            IToastNotification toastNotification,
            IHttpContextAccessor contextAccessor)
        {
            this.context = dbContext;
            this.toastNotification = toastNotification;
            this.cartHelper = new CartHelper(contextAccessor);
        }

        public IActionResult Add([FromRoute] Guid id)
        {

            var product = context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var cartJSON = cartHelper.GetCartJson();


            var cartsDomain = cartHelper.GetCartItems(cartJSON);

            var existingProduct = cartsDomain.FirstOrDefault(cart => cart.ProductId == id);
            var quantity = 1;

            if (existingProduct is null)
            {
                var cartItem = new CartItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = product.Id,
                    Quantity = quantity,
                    SubTotal = quantity * product.Price,
                };
                cartsDomain.Add(cartItem);

                cartHelper.ParseCartToJson(cartsDomain);

                toastNotification.AddSuccessToastMessage("A Product is added successfully");

                return RedirectToAction("Index", "Home");

            }

            quantity += existingProduct.Quantity;

            existingProduct.Quantity = quantity;
            existingProduct.SubTotal *= existingProduct.Quantity;

            cartHelper.ParseCartToJson(cartsDomain);
            toastNotification.AddSuccessToastMessage("A Product is added successfully");

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete([FromRoute] Guid id)
        {
            var cartJSON = cartHelper.GetCartJson();


            var cartsDomain = cartHelper.GetCartItems(cartJSON);

            foreach (var cart in cartsDomain)
            {
                if (cart.Id == id)
                {
                    cartsDomain.Remove(cart);
                    break;
                }
            }

            cartHelper.ParseCartToJson(cartsDomain);

            toastNotification.AddSuccessToastMessage("A Product is deleted successfully");

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Checkout()
        {
            cartHelper.ParseCartToJson(new List<CartItem>());

            toastNotification.AddInfoToastMessage("Thank you for ordering our product. Have a good day^^");
            return RedirectToAction("Index", "Home");
        }
    }
}
