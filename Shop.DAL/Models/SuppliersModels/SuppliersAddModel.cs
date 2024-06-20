

namespace Shop.DAL.Models.SuppliersModels
{
    public class SuppliersAddModel : BaseSuppliersModel
    {
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
