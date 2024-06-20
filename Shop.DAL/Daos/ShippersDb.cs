using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CategoryModels;
using Shop.DAL.Models.ShippersModels;


namespace Shop.DAL.Daos
{
    public class ShippersDb : IShippersDb
    {
        private readonly ShopContext context;
        public ShippersDb(ShopContext context)
        {
            this.context = context;

        }
        public ShippersModel GetShipper(int ShipperId)
        {
            throw new NotImplementedException();
        }

        public List<ShippersModel> GetShippers()
        {
            return this.context.Shippers.Where(catgo => !catgo.deleted)
                .Select(catgo => new ShippersModel()
                {
                    
                    address = catgo.address,
                    city = catgo.city,
                    phone = catgo.phone,
                    country = catgo.country,
                    name = catgo.name,
                    postalcode = catgo.postalcode,
                    shipperid = catgo.shipperid,
                    region = catgo.region,
                }


                ).ToList();
        }

        public void RemoveShipper(ShippersRemoveModel ShipperAdd)
        {
            throw new NotImplementedException();
        }

        public void SaveShipper(ShippersAddModel ShipperAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateShipper(ShippersUpdateModel ShipperAdd)
        {
            throw new NotImplementedException();
        }
    }
}
