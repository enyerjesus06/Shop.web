
using Shop.DAL.Models.SuppliersModels;


namespace Shop.DAL.Interfaces
{
    public interface ISuppliersDb
    {
        List<SuppliersModel> GetSuppliers();
        SuppliersModel GetSupplier(int supplierid);

        void SaveSupplier(SuppliersAddModel SupplierSave);
        void UpdateSupplier(SuppliersUpdateModel SupplierUpdate);
        void RemoveSupplier(SuppliersRemoveModel SupplierRemove);
    }
}
