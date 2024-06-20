

namespace Shop.DAL.Models.CustomersModels
{
    public abstract class BaseCustomersModel : BaseCustomersId
    {
        public  string companyname { get; set; }
        public  string contactname { get; set; }
        public string contacttitle { get; set; }
        
        
    }
}
