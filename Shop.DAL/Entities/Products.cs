using System.ComponentModel.DataAnnotations;

using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Products : BaseEntity
    {
        [Key]
            public int productid { get; set; }
            public string productname { get; set; }
            public int supplierid { get; set; }
            public int categoryid { get; set; }
            public decimal unitprice { get; set; }
            public bool discontinued { get; set; }
        
    }

}

