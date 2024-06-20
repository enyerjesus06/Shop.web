

namespace Shop.DAL.Models.ShippersModels
{
    public class ShippersAddModel
    {
        public  string name { get; set; }
        public  string address { get; set; }
        public  string city { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }
        public string country { get; set; }
        public  string phone { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
