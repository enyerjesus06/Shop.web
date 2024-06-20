

namespace Shop.DAL.Models.ShippersModels
{
    public class ShippersRemoveModel : BaseShippersId
    {
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
