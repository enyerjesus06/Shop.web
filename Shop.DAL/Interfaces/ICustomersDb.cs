using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CategoryModels;
using Shop.DAL.Models.CustomersModels;


namespace Shop.DAL.Interfaces
{
    public interface ICustomersDb
    {
        List<CustomersModel> GetCustomers();
        CustomersModel GetCustomer(int customerid);

        void SaveCustomer(CustomersAddModel CustomerSave);
        void UpdateCustomer(CustomersUpdateModel CustomerUpdate);
        void RemoveCustomer(CustomersRemoveModel CustomerRemove);
    }
}
