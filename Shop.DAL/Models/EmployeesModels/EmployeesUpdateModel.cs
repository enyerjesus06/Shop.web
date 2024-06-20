

namespace Shop.DAL.Models.EmployeesModels
{
    public class EmployeesUpdateModel : BaseEmployeesModel
    { 
        public DateTime hiredate { get; set; }
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
    }
}
