using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Models.CategoryModels
{
    public abstract class BaseCategoryId
    {
        [Key]
        public  int categoryid { get; set; }
    }
}
