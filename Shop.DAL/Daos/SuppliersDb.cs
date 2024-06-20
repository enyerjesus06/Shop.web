using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CategoryModels;
using Shop.DAL.Models.SuppliersModels;


namespace Shop.DAL.Daos
{
    public class SuppliersDb : ISuppliersDb
    {
        private readonly ShopContext context;
        public SuppliersDb(ShopContext context)
        {
            this.context = context;

        }
        public SuppliersModel GetSupplier(int SupplierId)
        {
            throw new NotImplementedException();
        }

        public List<SuppliersModel> GetSuppliers()
        {
            return this.context.Suppliers.Where(catgo => !catgo.deleted)
                .Select(catgo => new SuppliersModel()
                {
                    address = catgo.address,
                    companyname = catgo.companyname,
                    contactname = catgo.contactname,
                    city = catgo.city,
                    country = catgo.country,
                    contacttitle = catgo.contacttitle,
                    phone = catgo.phone,
                    postalcode = catgo.postalcode,
                    fax = catgo.fax,
                    region = catgo.region,
                    supplierid = catgo.supplierid 
                }

                ).ToList();
        }

        public void RemoveSupplier(SuppliersRemoveModel SupplierAdd)
        {
            throw new NotImplementedException();
        }

        public void SaveSupplier(SuppliersAddModel SupplierAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateSupplier(SuppliersUpdateModel SupplierAdd)
        {
            throw new NotImplementedException();
        }
    }
}
