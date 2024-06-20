using Microsoft.EntityFrameworkCore;
using Shop.DAL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    
    public class Categories : BaseEntity
    {
        [Key]
        public  int categoryid { get; set; }
        public  string categoryname { get; set;}
        public  string description { get; set;}
    }
}
