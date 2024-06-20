using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CategoryModels;
using Shop.DAL.Models.EmployeesModels;
using Shop.DAL.Models.OrdersModel;


namespace Shop.DAL.Daos
{
    public class OrderDb : IOrderDb
    {
        private readonly ShopContext context;
        public OrderDb(ShopContext context)
        {
            this.context = context;

        }
        public OrderModel GetOrder(int OrderId)
        {
            var category = this.context.Orders.Find(OrderId);

            if (category == null)
            {
                ArgumentNullException.ThrowIfNull(OrderId, "El objeto no puede ser Nulo");
            }

            OrderModel model = new OrderModel
            {
                shipaddress = category.shipaddress,
                shipcity = category.shipcity,
                shipcountry = category.shipcountry,
                shipname = category.shipname,
                


            };

            return model;
        }

        public List<OrderModel> GetOrders()
        {
            return this.context.Orders
                .Select(ord => new OrderModel()
                {
                    orderid = ord.orderid,
                    custid = ord.custid,
                    empid = ord.empid,
                    orderdate = ord.orderdate,
                    requireddate = ord.requireddate,
                    shippeddate = ord.shippeddate,
                    shipperid = ord.shipperid,
                    freight = ord.freight,
                    shipname = ord.shipname,
                    shipaddress = ord.shipaddress,
                    shipcity = ord.shipcity,
                    shipregion = ord.shipregion,
                    shippostalcode = ord.shippostalcode,
                    shipcountry = ord.shipcountry
                })
                .ToList();
        }


        public void RemoveOrder(OrderRemoveModel OrderAdd)
        {
            var employeeToDelete = context.Orders.Find(OrderAdd.orderid);

            if (employeeToDelete != null)
            {
                employeeToDelete.orderid = OrderAdd.orderid;
                
           

                this.context.Orders.Update(employeeToDelete);
                this.context.SaveChanges();
            }
        }

        public void SaveOrder(OrderAddModel OrderAdd)
        {
            var existingEmployee = this.context.Orders.Find(OrderAdd.custid);

            if (existingEmployee == null)
            {
                throw new KeyNotFoundException("Empleado no encontrado.");
            }


            existingEmployee.freight = OrderAdd.freight;
            existingEmployee.shipperid = OrderAdd.shipperid;
            existingEmployee.shippeddate = OrderAdd.shippeddate;
            existingEmployee.shipname = OrderAdd.shipname;
            existingEmployee.shipregion = OrderAdd.shipregion;


            this.context.Orders.Add(existingEmployee);
            this.context.SaveChanges();
        }

        public void UpdateOrder(OrderUpdateModel OrderAdd)
        {
            var existingOrder = this.context.Orders.Find(OrderAdd.empid);

            if (existingOrder == null)
            {
                throw new KeyNotFoundException("Cliente no encontrado.");
            }


            existingOrder.requireddate = DateTime.Now;
            existingOrder.orderdate = DateTime.Now;
            existingOrder.freight = OrderAdd.freight;
            existingOrder.shipperid = OrderAdd.shipperid;
            existingOrder.shipcountry = OrderAdd.shipcountry;   
            existingOrder.shipaddress = OrderAdd.shipaddress;



            this.context.Orders.Update(existingOrder);
            this.context.SaveChanges();
        }
    }
}
