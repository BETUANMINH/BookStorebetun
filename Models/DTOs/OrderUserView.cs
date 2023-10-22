namespace BookShoppingCartMVC.Models.DTOs
{
    public class OrderUserView
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public String StatusName { get; set; }
        public bool IsDeleted { get; set; }
    }

}
