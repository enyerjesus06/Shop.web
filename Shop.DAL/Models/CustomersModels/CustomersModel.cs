

namespace Shop.DAL.Models.CustomersModels
{
    public class CustomersModel : BaseCustomersModel
    {
        public  string email { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
