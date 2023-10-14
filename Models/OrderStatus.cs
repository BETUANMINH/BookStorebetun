using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMVC.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        public int Id { get; set; }
        public int statusId { get; set; }
        [Required]
        [MaxLength(20)] 
        public string StatusName { get; set; }
    }
}
