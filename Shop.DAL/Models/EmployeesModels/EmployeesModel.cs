

namespace Shop.DAL.Models.EmployeesModels
{
    public class EmployeesModel : BaseEmployeesInformation
    {
        public int empid { get; set; }
        public string firstname { get; set; }
        public  string lastname { get; set; }

        public  string phone { get; set; }
    }
}
