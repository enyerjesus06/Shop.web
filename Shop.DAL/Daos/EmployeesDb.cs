using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CustomersModels;
using Shop.DAL.Models.EmployeesModels;


namespace Shop.DAL.Daos
{
    public class EmployeesDb : IEmployeesDb
    {
        private readonly ShopContext context;
        public EmployeesDb(ShopContext context)
        {
            this.context = context;

        }
        public List<EmployeesModel> GetEmployees()
        {
            return this.context.Employees.Where(employ => !employ.deleted)
                .Select(employ => new EmployeesModel()
                {
                    creation_user = employ.creation_user,
                    creation_date = employ.creation_date,
                    city = employ.city,
                    firstname = employ.firstname,
                    lastname = employ.lastname,
                    country = employ.country,
                    address = employ.address,
                    birthdate = employ.birthdate,
                    empid = employ.empid,
                    mgrid = employ.mgrid,
                    phone = employ.phone,
                    postalcode = employ.postalcode,
                    region = employ.region,
                    titleofcourtesy = employ.titleofcourtesy,
                    title = employ.title,


                }).ToList();
        }
        public EmployeesModel GetEmployee(int employeeid)
        {
            var category = this.context.Employees.Find(employeeid);

            if (category == null)
            {
                ArgumentNullException.ThrowIfNull(employeeid, "El objeto no puede ser Nulo");
            }

            EmployeesModel model = new EmployeesModel
            {
                firstname = category.firstname,
                lastname = category.lastname,
                address = category.address,
                city = category.city,
                country = category.country,
                phone = category.phone,
                titleofcourtesy = category.titleofcourtesy,
                title = category.title,


            };

            return model;
        }

        public void SaveEmployee(EmployeesAddModel EmployeeSave)
        {
            var existingEmployee = this.context.Employees.Find(EmployeeSave.creation_date);

            if (existingEmployee == null)
            {
                throw new KeyNotFoundException("Empleado no encontrado.");
            }


            existingEmployee.creation_user = EmployeeSave.creation_user;
            existingEmployee.birthdate = DateTime.Now;
            existingEmployee.hiredate = DateTime.Now;
            existingEmployee.creation_date = DateTime.Now;
            existingEmployee.title = EmployeeSave.title;


            this.context.Employees.Add(existingEmployee);
            this.context.SaveChanges();
        }
        public void UpdateEmployee(EmployeesUpdateModel EmployeeAdd)
        {
            var existingEmployee = this.context.Employees.Find(EmployeeAdd.empid);

            if (existingEmployee == null)
            {
                throw new KeyNotFoundException("Empleado no encontrado.");
            }


            existingEmployee.firstname = EmployeeAdd.firstname;
            existingEmployee.lastname = EmployeeAdd.lastname;
            existingEmployee.hiredate = EmployeeAdd.hiredate;
            existingEmployee.modify_user = EmployeeAdd.modify_user;
            existingEmployee.modify_date = DateTime.Now;
            existingEmployee.empid = EmployeeAdd.empid;



            this.context.Employees.Update(existingEmployee);
            this.context.SaveChanges();
        }
        public void RemoveEmployee(EmployeesRemoveModel EmployeeRemove)
        {
            var employeeToDelete = context.Employees.Find(EmployeeRemove.deleted);

            if (employeeToDelete != null)
            {
                employeeToDelete.deleted = true;
                employeeToDelete.delete_date = DateTime.Now;
                employeeToDelete.delete_user = EmployeeRemove.delete_user;

                this.context.Employees.Update(employeeToDelete);
                this.context.SaveChanges();
            }
        }

      

        
    }
}
