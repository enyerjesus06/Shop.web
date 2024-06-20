using System.ComponentModel.DataAnnotations;

using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Suppliers : CompanyContactInfo
    {
        [Key]
        public int supplierid { get; set; }

    }
}
