namespace Shop.DAL.Models.CategoryModels
{
    public class CategoryModel : BaseCategoryModel
    {
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }

    }
}
