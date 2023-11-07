using System.Threading.Tasks;

namespace BookShoppingCartMVC
{
    public interface ICartRepository
    {
        Task<int> AddItem(int BookId, int qty);
        Task<int> RemoveItem(int BookId);
        Task<ShoppingCart> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<ShoppingCart> GetCart(string userId);
        Task<bool> DoCheck();
        Task<int> RemoveItemAll(int BookId);
    }
}