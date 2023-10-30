using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookShoppingCartMVC.Controllers
{
    public class UserOrderController : Controller
    {
        private readonly IUserOrderRepository _userOrderRepository;
        public UserOrderController(IUserOrderRepository userOrderRepository)
        {
               _userOrderRepository = userOrderRepository;
        }
        [Authorize]
        public async Task<IActionResult> UserOrders()
        {
            var orders = await _userOrderRepository.UserOrders();

            return View(orders);
        }
        //change status order to Cancelled
        [Authorize]
        public async Task<IActionResult> CancelOrder(int id)
        {
            await _userOrderRepository.CancelOrder(id);

            return RedirectToAction("UserOrders");
        }

    }
}
