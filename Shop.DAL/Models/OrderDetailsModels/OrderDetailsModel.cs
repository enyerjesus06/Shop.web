namespace Shop.DAL.Models.OrderDetailsModels
{
    public class OrderDetailsModel
    {
        public int orderid { get; set; }
        public string productid { get; set; }
        public decimal unitprice { get; set; }
        public short qty { get; set; }
        public decimal discount { get; set; }

    }
}
