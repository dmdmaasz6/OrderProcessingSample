using System.ComponentModel.DataAnnotations;

namespace OrderProcessingSample.Models
{
    public class OrderItems
    {
        [Key]
        public int Id { get; set; }
        public int Qty { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public virtual Orders Order { get; set; }
        public virtual Items Item { get; set; }
    }
}
