
namespace Shop.DAL.Models.EmployeesModels
{
    public abstract class BaseEmployeesModel : BaseEmployeesId 
    {
        public string firstname { get; set; }
        public  string lastname { get; set; }
        
        public  string phone { get; set; }
    }
}
