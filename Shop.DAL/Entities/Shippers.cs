using System.ComponentModel.DataAnnotations;

using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Shippers : ContactDetails
    {
        [Key]
        public int shipperid { get; set; }
        public string name { get; set; }

    }
}
