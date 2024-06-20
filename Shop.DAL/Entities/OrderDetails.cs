using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using System.Data.SqlTypes;

namespace Shop.DAL.Entities
{
    public class OrderDetails
    {
        [Key]
        public int orderid { get; set; }
        
        public  string productid { get; set; }
        public decimal unitprice { get; set; }
        public short qty { get; set; }
        public decimal discount { get; set;}





    }
}
