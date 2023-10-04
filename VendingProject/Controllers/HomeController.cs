using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VendingProject.Helpers;
using VendingProject.Models;
using VendingProject.Models.ViewModel;

namespace VendingProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VendingDbContext dbContext;
        private readonly ICartHelper cartHelper;
        private readonly IHttpContextAccessor contextAccessor;


        public HomeController(ILogger<HomeController> logger,
            VendingDbContext dbContext, ICartHelper cartHelper, 
            IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            this.dbContext = dbContext;
            this.contextAccessor = contextAccessor;
            this.cartHelper = new CartHelper(contextAccessor);
        }

        public IActionResult Index()
        {
            var products = dbContext.Products.ToList();
            var cartJSON = cartHelper.GetCartJson();

            var cartItemDomain = cartHelper.GetCartItems(cartJSON);

            var cartViewModel = new List<CartViewModel>();

            foreach (var cart in cartItemDomain)
            {
                cartViewModel.Add(new CartViewModel
                {
                    Id = cart.Id,
                    Product = dbContext.Products.FirstOrDefault(p => p.Id == cart.ProductId),
                    Quantity = cart.Quantity,
                    SubTotal = cart.SubTotal,
                });
            }


            var homeViewModel = new HomeViewModel {
                Products = products,
                CartItems = cartViewModel
            };

            return View(homeViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}