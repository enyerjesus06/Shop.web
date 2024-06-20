

namespace Shop.DAL.Models.EmployeesModels
{
    public class EmployeesRemoveModel : BaseEmployeesId
    {
       
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }

    }
}
