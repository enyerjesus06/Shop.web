

namespace Shop.DAL.Models.SuppliersModels
{
    public class SuppliersUpdateModel : BaseSuppliersModel
    {
         public int supplierid { get; set; }
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
    }
}
