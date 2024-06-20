namespace Shop.DAL.Models.CategoryModels
{
    public class CategoryAddModel : BaseCategoryId
    {
        public  string categoryname { get; set; }
        public  string description { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
