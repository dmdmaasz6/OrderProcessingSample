namespace OrderProcessingSample.Models.ViewModels
{
    public class OrderProcessingViewModel
    {
        public List<OrderViewModel> Order { get; set; }

    }

    public class OrderViewModel
    {
        public int ItemId { get; set; }
        public float UnitPrice { get; set; }
        public int Qty { get; set; }
    }
}
