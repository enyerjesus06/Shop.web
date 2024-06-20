namespace Shop.DAL.Models.CategoryModels
{
    public class CategoryUpdateModel : BaseCategoryModel
    {
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }

    }
}
