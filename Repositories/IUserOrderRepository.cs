namespace BookShoppingCartMVC.Repositories
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders();
        Task CancelOrder(int id);
    }
}