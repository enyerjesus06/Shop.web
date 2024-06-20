

namespace Shop.DAL.Models.CustomersModels
{
    public class CustomersUpdateModel : BaseCustomersModel
    {

        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }

        
    }
}
