
using Shop.DAL.Models.ProductsModels;


namespace Shop.DAL.Interfaces
{
     public interface IProductsDb
    {
        List<ProductsModel> GetProducts();
        ProductsModel GetProduct(int customerid);

        void SaveProduct(ProductsAddModel ProductSave);
        void UpdateProduct(ProductsUpdateModel ProductUpdate);
        void RemoveProduct(ProductsRemoveModel ProductRemove);
    }
}
