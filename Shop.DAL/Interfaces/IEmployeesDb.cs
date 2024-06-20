
using Shop.DAL.Models.EmployeesModels;


namespace Shop.DAL.Interfaces
{
    public interface IEmployeesDb
    {
        List<EmployeesModel> GetEmployees();
        EmployeesModel GetEmployee(int employeeid);

        void SaveEmployee(EmployeesAddModel EmployeeSave);
        void UpdateEmployee(EmployeesUpdateModel EmployeeUpdate);
        void RemoveEmployee(EmployeesRemoveModel EmployeeRemove);
    }
}
