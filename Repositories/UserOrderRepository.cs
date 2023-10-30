using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookShoppingCartMVC.Repositories
{
    public class UserOrderRepository: IUserOrderRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserOrderRepository(ApplicationDbContext db,IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IEnumerable<Order>> UserOrders()
        {
            var userId = GetUserId();
            if(string.IsNullOrEmpty(userId))
            {
                throw new Exception("User is not logged in");
            }
            var orders = await _db.Orders
                .Include(x => x.OrderStatus)
                .Include(x => x.OrderDetail)
                .ThenInclude(x => x.Book)
                .ThenInclude(x => x.Genre)
                .Where(o => o.UserID == userId)
                .ToArrayAsync();
            return orders;
        }
        private string GetUserId()
        {
            var user = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(user);
            return userId;
        }
        //change status order to Cancelled
        public async Task CancelOrder(int id)
        {
            var order = await _db.Orders.FindAsync(id);
            order.OrderStatusId = 4;
            _db.Orders.Update(order);
            await _db.SaveChangesAsync();
        }
    }
}
