using Shop.DAL.Models.OrderDetailsModels;

namespace Shop.DAL.Interfaces
{
    public interface IOrderDetailsDb
    {
        List<OrderDetailsModel> GetOrderDetails();
        OrderDetailsModel GetDetails(int orderdetailsid);

        
    }
}
