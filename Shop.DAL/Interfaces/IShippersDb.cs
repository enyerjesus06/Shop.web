
using Shop.DAL.Models.ShippersModels;


namespace Shop.DAL.Interfaces
{
    public interface IShippersDb
    {
        List<ShippersModel> GetShippers();
        ShippersModel GetShipper(int shipperid);

        void SaveShipper(ShippersAddModel ShipperSave);
        void UpdateShipper(ShippersUpdateModel ShipperUpdate);
        void RemoveShipper(ShippersRemoveModel ShipperRemove);
    }
}
