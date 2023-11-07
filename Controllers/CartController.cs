using Microsoft.AspNetCore.Mvc;

namespace BookShoppingCartMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepo;

        public CartController(ICartRepository cartRepo)
        {
            _cartRepo = cartRepo;
        }

        public async Task<IActionResult> AddItem(int bookId, int qty = 1, int redirect = 0)
        {
            var cartCount = await _cartRepo.AddItem(bookId, qty);
            if (redirect ==  0)
            {
                return Ok(cartCount);
            }
            return RedirectToAction("GetUserCart");

        }
        public async Task<IActionResult> RemoveItem(int bookId)
        {
            var cartCount = await _cartRepo.RemoveItem(bookId);
            return RedirectToAction("GetUserCart");
        }
        //remove cart item to 0 quantity of a specific book
        public async Task<IActionResult> RemoveCartItem(int bookId)
        {
            var cartCount = await _cartRepo.RemoveItemAll(bookId);
            return RedirectToAction("GetUserCart");
                
        }

        public async Task<IActionResult> GetUserCart()
        {
            var cart = await _cartRepo.GetUserCart();
            if (cart is null)
            {
                ViewBag.Error = "You are not logged in";
                return View();
            }
            return View(cart);
        }
        public async Task<IActionResult> GetTotalItemInCart()
        {
            int cartItem = await _cartRepo.GetCartItemCount();
            return Ok(cartItem);
        }
        public async Task<IActionResult> CheckOut()
        {
            bool ischeckout = await _cartRepo.DoCheck();
            if (!ischeckout)
            {
               throw new Exception("Error while checkout");
            }
            return RedirectToAction("Index", "Home");
            
        }
    }
}
