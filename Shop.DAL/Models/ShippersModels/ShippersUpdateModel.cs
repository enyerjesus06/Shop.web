

namespace Shop.DAL.Models.ShippersModels
{
    public class ShippersUpdateModel : BaseShippersModel
    {
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
    }
}
