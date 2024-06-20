using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CategoryModels;
using Shop.DAL.Models.OrderDetailsModels;

namespace Shop.DAL.Daos
{
    public class OrderDetailsDb : IOrderDetailsDb
    {
        private readonly ShopContext context;
        public OrderDetailsDb(ShopContext context)
        {
            this.context = context;

        }
        public OrderDetailsModel GetDetails(int OrderDetailsId)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetailsModel> GetOrderDetails()
        {
            return this.context.OrderDetails
                .Select(ordtails => new OrderDetailsModel()
                {
                    discount = ordtails.discount,
                    orderid = ordtails.orderid,
                    productid = ordtails.productid,
                    qty = ordtails.qty,
                    unitprice = ordtails.unitprice,
                }

                ).ToList();
        }
    }
}
