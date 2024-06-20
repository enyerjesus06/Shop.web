using Microsoft.EntityFrameworkCore;
using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CategoryModels;
using Shop.DAL.Models.CustomersModels;
using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;



namespace Shop.DAL.Daos
{
    public class CustomersDb : ICustomersDb
    {
        private readonly ShopContext context;
        public CustomersDb(ShopContext context)
        {
            this.context = context;

        }
        public CustomersModel GetCustomer(int CustomerId)
        {
            var category = this.context.Customers.Find(CustomerId);

            if (category == null)
            {
                ArgumentNullException.ThrowIfNull(CustomerId, "El objeto no puede ser Nulo");
            }

            CustomersModel model = new CustomersModel
            {
               companyname = category.companyname,
               contactname = category.contactname,
               contacttitle = category.contacttitle,
               creation_user = category.creation_user,
               email = category.email,
               custid = category.custid,


            };

            return model;
        }

        public List<CustomersModel> GetCustomers()
        {
            return this.context.Customers.Where(cust => !cust.deleted)
                .Select(cust => new CustomersModel()
                {
                    custid = cust.custid,
                    companyname = cust.companyname,
                    contactname = cust.contactname,
                    contacttitle = cust.contacttitle,
                    creation_user = cust.creation_user,
                    creation_date = cust.creation_date,
                    email = cust.email,
                }

                ).ToList();
        }

        public void RemoveCustomer(CustomersRemoveModel CustomerRemove)
        {
            var customerToDelete = context.Customers.Find(CustomerRemove.custid);

            if (customerToDelete != null)
            {
                customerToDelete.deleted = true;
                customerToDelete.delete_date = DateTime.Now;
                customerToDelete.delete_user = CustomerRemove.delete_user;

                this.context.Customers.Update(customerToDelete);
                this.context.SaveChanges();
            }
        }

        public void SaveCustomer(CustomersAddModel CustomerAdd)
        {
            using (var transaction = this.context.Database.BeginTransaction())
            {
                this.context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Customers ON");

                Customers customers = new Customers()
                {


                    contacttitle = CustomerAdd.contacttitle,
                    companyname = CustomerAdd.companyname,
                    creation_date = DateTime.Now,
                    
                    email = CustomerAdd.email,
                    address = CustomerAdd.address,
                    country = CustomerAdd.country,
                    phone = CustomerAdd.phone,
                    postalcode = CustomerAdd.postalcode,
                    region = CustomerAdd.region,
                    city = CustomerAdd.city,
                    contactname = CustomerAdd.contactname,

                };
                this.context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Customers OFF");

                transaction.Commit();

                this.context.Customers.Add(customers);
                this.context.SaveChanges();

              
            }
        }


           

        
        public void UpdateCustomer(CustomersUpdateModel CustomerUpdate)
        {
            using (var transaction = this.context.Database.BeginTransaction())
            {
                this.context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Categories ON");

                Customers customers = new Customers()
                {
                    custid = CustomerUpdate.custid,
                    contacttitle = CustomerUpdate.contacttitle,
                    modify_user = CustomerUpdate.modify_user,
                    modify_date = DateTime.Now,
                  
                    
                };

                this.context.Customers.Update(customers);
                this.context.SaveChanges();
                this.context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Categories OFF");

                transaction.Commit();
            }

        }

    }
    
     
}
