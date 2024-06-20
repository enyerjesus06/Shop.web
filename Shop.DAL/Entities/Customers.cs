

using Shop.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.Entities
{
    public class Customers : CompanyContactInfo
    {
        [Key]
        public int custid { get; set; }
        public  string email { get; set; }
    }
}
