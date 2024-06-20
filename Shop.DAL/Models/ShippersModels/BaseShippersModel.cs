

namespace Shop.DAL.Models.ShippersModels
{
    public abstract class BaseShippersModel : BaseShippersId
    {
        public  string name { get; set; }
        public  string address { get; set; }
        public  string city { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }
        public  string country { get; set; }
        public  string phone { get; set; }
    }
}
