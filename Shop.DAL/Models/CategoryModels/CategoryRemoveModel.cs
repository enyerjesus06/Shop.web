namespace Shop.DAL.Models.CategoryModels
{
    public class CategoryRemoveModel : BaseCategoryId
    {
        
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }

    }
}
