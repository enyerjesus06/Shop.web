using Shop.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    public class Categories : BaseEntity
    {
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set;}
        public string? Description { get; set;}
    }
}
