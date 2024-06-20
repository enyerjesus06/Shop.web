using Shop.DAL.Models.CategoryModels;


namespace Shop.DAL.Interfaces
{
    public interface ICategoriesDb
    {
        List <CategoryModel> GetCategories();
        CategoryModel GetCategory(int categoryid);

        void SaveCategory(CategoryAddModel CategorySave);
        void UpdateCategory(CategoryUpdateModel CategoryUpdate);
        void RemoveCategory(CategoryRemoveModel CategoryRemove);

    }
}
