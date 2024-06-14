

using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Customers : Identity
    {
        public int? CustId { get; set; }
        public string? Email { get; set; }
    }
}
