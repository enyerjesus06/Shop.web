

namespace Shop.DAL.Models.CategoryModels
{
    public abstract class BaseCategoryModel : BaseCategoryId
    {
       
        public  string categoryname { get; set; }
        public  string description { get; set; }
       
    }
}
