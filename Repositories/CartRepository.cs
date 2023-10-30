using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookShoppingCartMVC.Repositories
{
    public class CartRepository: ICartRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CartRepository(ApplicationDbContext db, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

        }
        public async Task<int> AddItem(int BookId, int qty)
        {
            string userId = GetUserId();
            using var transaction = _db.Database.BeginTransaction();
            try
            {

            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("User is not logged in");
            }
            var cart = await GetCart(userId);

            if(cart is null)
            {

                cart = new ShoppingCart
                {
                    UserID = userId
                };
                _db.ShoppingCarts.Add(cart);
            }
            _db.SaveChanges();
            var cartItem = await _db.CartDetails
                    .FirstOrDefaultAsync(c => c.BookId == BookId && c.ShoppingCartId == cart.Id);
                if(cartItem is not null)
                {
                    cartItem.Quantity += qty;
                }
                else
                {
                    var book = await _db.Books.FindAsync(BookId);
                    cartItem = new CartDetail
                    {
                        BookId = BookId,
                        Quantity = qty,
                        ShoppingCartId = cart.Id,
                        UnitPrice = book.Price

                    };
                    _db.CartDetails.Add(cartItem);
                }
                _db.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
            }
            var totalItems = await GetCartItemCount(userId);
            return totalItems;
            

            
        }
        public async Task<int> GetCartItemCount(string userId = "")
        {
            if(string.IsNullOrEmpty(userId))
            {
                userId = GetUserId();
            }
            var data = await (from cart in _db.ShoppingCarts
                        join cartDetail in _db.CartDetails
                        on cart.Id equals cartDetail.ShoppingCartId
                        where cart.UserID == userId
                        select new {cartDetail.Id}).ToListAsync();
            return data.Count;
        }
        public async Task<int> RemoveItem(int BookId)
        {
            //using var transaction = _db.Database.BeginTransaction();
                string userId = GetUserId();
            try
            {

                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("User is not logged in");
                }
                var cart = await GetCart(userId);

                if (cart is null)
                {
                    throw new Exception("Invalid cart");
                }
                var cartItem =  await _db.CartDetails
                    .FirstOrDefaultAsync(a => a.ShoppingCartId == cart.Id && a.BookId == BookId);
                if (cartItem is null)
                {
                    throw new Exception("Item not found in cart");
                }
                else if (cartItem.Quantity == 1)
                {
                    _db.CartDetails.Remove(cartItem);
                }
                else
                {
                    cartItem.Quantity = cartItem.Quantity - 1;
                }
                _db.SaveChanges();

                //transaction.Commit();
            }
            catch (Exception)
            {
            }
            var totalItems = await GetCartItemCount(userId);
            return totalItems;



        }
        public async Task<ShoppingCart> GetUserCart()
        {
            var userId = GetUserId();
            if(userId is null)
            {
                return null;
            }
            var shoppingCarts = await _db.ShoppingCarts
                .Include(c => c.CartDetails).
                ThenInclude(c => c.Book)
                .ThenInclude(c => c.Genre)
                .Where(c => c.UserID == userId).FirstOrDefaultAsync();
            return shoppingCarts;
        }

        public async Task<ShoppingCart> GetCart(string userId)
        {
            var cart = await _db.ShoppingCarts.FirstOrDefaultAsync(c => c.UserID == userId);
            return cart;

        }
        public async Task<bool> DoCheck()
        {
            using var transaction = _db.Database.BeginTransaction();
            try
            {
                //move data from cartDetail to order and  orderDetail then remove cart detail
                //entry -> order, orderdetail
                //remove data -> cartDetail
                var userId = GetUserId();
                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("User is not logged in");
                }
                var cart = await GetCart(userId);
                if(cart is null)
                {
                    throw new Exception("Invalid cart");
                }
                var cartDetails = _db.CartDetails
                    .Include(c => c.Book)
                    .Where(c => c.ShoppingCartId == cart.Id).ToList();
                if(cartDetails.Count == 0)
                {
                    throw new Exception("Cart is empty");
                }
                var order = new Order
                {
                    UserID = userId,
                    CreateDate = DateTime.Now,
                    OrderStatusId = 1 
                    // 1-pending, 2-shipped, 3-delivered, 4-cancelled, 5-return , 6-refund
                };
                _db.Orders.Add(order);
                _db.SaveChanges();
                foreach (var item in cartDetails)
                {
                    var orderDetail = new OrderDetail
                    {
                        BookId = item.BookId,
                        OrderId = order.Id,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice,
                    };
                    _db.OrderDetails.Add(orderDetail);
                }
                _db.SaveChanges();
                _db.CartDetails.RemoveRange(cartDetails);
                _db.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private string GetUserId()
        {
            var user = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(user);
            return userId;
        }
    }
}
