using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CategoryModels;
using Shop.DAL.Models.OrdersModel;
using Shop.DAL.Models.ProductsModels;


namespace Shop.DAL.Daos
{
    public class ProductsDb : IProductsDb
    {
        private readonly ShopContext context;
        public ProductsDb(ShopContext context)
        {
            this.context = context;

        }
        public ProductsModel GetProduct(int CustomerId)
        {
            var category = this.context.Products.Find(CustomerId);

            if (category == null)
            {
                ArgumentNullException.ThrowIfNull(CustomerId, "El objeto no puede ser Nulo");
            }

            ProductsModel model = new ProductsModel
            {
                productname = category.productname,
                supplierid = category.supplierid,
                categoryid = category.categoryid,
                discontinued = category.discontinued,
                creation_date = category.creation_date,
                productid = category.productid,
                creation_user = category.creation_user,
                unitprice = category.unitprice,



            };

            return model;
        }

        public List<ProductsModel> GetProducts()
        {
            return this.context.Products.Where(produc => !produc.deleted)
                .Select(produc => new ProductsModel()
                {
                    productname = produc.productname,
                    productid = produc.productid,
                    creation_date = produc.creation_date,
                    categoryid = produc.categoryid,
                    supplierid = produc.supplierid,
                    creation_user = produc.creation_user,
                    unitprice = produc.unitprice,
                    discontinued = produc.discontinued,
                }

                ).ToList();
        }

        public void RemoveProduct(ProductsRemoveModel ProductAdd)
        {
            var employeeToDelete = context.Products.Find(ProductAdd.deleted);

            if (employeeToDelete != null)
            {
                employeeToDelete.deleted = true;
                employeeToDelete.delete_date = DateTime.Now;
                employeeToDelete.delete_user = null;



                this.context.Products.Update(employeeToDelete);
                this.context.SaveChanges();
            }
        }

        public void SaveProduct(ProductsAddModel ProductAdd)
        {
            var existingEmployee = this.context.Products.Find(ProductAdd.categoryid);

            if (existingEmployee == null)
            {
                throw new KeyNotFoundException("Producto no encontrado.");
            }


            existingEmployee.categoryid = ProductAdd.categoryid;
            existingEmployee.productname = ProductAdd.productname;
            existingEmployee.unitprice = ProductAdd.unitprice;
            existingEmployee.supplierid = ProductAdd.supplierid;
            existingEmployee.creation_date = DateTime.Now;


            this.context.Products.Add(existingEmployee);
            this.context.SaveChanges();
        }

        public void UpdateProduct(ProductsUpdateModel ProductAdd)
        {
            var existingOrder = this.context.Products.Find(ProductAdd.categoryid);

            if (existingOrder == null)
            {
                throw new KeyNotFoundException("Cliente no encontrado.");
            }


            existingOrder.productid = ProductAdd.productid;
            existingOrder.modify_date = ProductAdd.modify_date;
            existingOrder.modify_user = ProductAdd.modify_user;
            existingOrder.productname = ProductAdd.productname;
           



            this.context.Products.Update(existingOrder);
            this.context.SaveChanges();
        }
    }
    
}
