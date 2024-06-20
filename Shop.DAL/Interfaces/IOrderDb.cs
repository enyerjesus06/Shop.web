
using Shop.DAL.Models.OrdersModel;


namespace Shop.DAL.Interfaces
{
    public interface IOrderDb
    {
        List<OrderModel> GetOrders();
        OrderModel GetOrder(int orderid);

        void SaveOrder(OrderAddModel OrderSave);
        void UpdateOrder(OrderUpdateModel OrderUpdate);
        void RemoveOrder(OrderRemoveModel OrderRemove);
    }
}
