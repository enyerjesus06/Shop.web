

namespace Shop.DAL.Models.CustomersModels
{
    public class CustomersRemoveModel : BaseCustomersId
    {
        
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
