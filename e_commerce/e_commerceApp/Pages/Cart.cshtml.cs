using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;
using e_commerceApp.Infrastructe.Extensions;

namespace e_commerceApp.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager _manager;
        public Cart Cart { get; set; }//Ioc 
        public CartModel(IServiceManager manager, Cart cartService)
        {
            _manager = manager;
            Cart = cartService;
        }
        public string ReturnUrl { get; set; } = "/";

        public IActionResult OnPost(int productId, string returnUrl)
        {
            Product? product = _manager.ProductService.GetOneProduct(productId, false);

            if (product is not null)
            {
                // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, 1);
                // HttpContext.Session.SetJson<Cart>("cart",Cart);
            }
            return Page(); // returnUrl
        }

        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Product.ProductID.Equals(id)).Product);
            //HttpContext.Session.SetJson<Cart>("cart", Cart);
            return Page();
        }
    }
}