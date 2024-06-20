using Microsoft.EntityFrameworkCore;
using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CategoryModels;
using System.Runtime.CompilerServices;


namespace Shop.DAL.Daos
{
    public class CategoriesDb : ICategoriesDb
    {
        private readonly ShopContext context;
        public CategoriesDb(ShopContext context)
        {
            this.context = context;
        
        }
        
        public List<CategoryModel> GetCategories()
        {
            
            return this.context.Categories.Where(catgo => !catgo.deleted)
                .Select(catgo => new CategoryModel() 
                {
                    
                    description = catgo.description,
                    creation_date = catgo.creation_date,
                    categoryid = catgo.categoryid,
                    categoryname = catgo.categoryname,
                    creation_user = catgo.creation_user,
                    
                }

               ).ToList(); 
        }

        public CategoryModel GetCategory(int categoryid)
        {
            var category = this.context.Categories.Find(categoryid);

            CategoryModel model = new CategoryModel()
            {

                description = category.description,
                creation_date = category.creation_date,
                categoryname = category.categoryname,
                creation_user = category.creation_user,
            };

                
            return model;
        }





        public void SaveCategory(CategoryAddModel CategorySave)
        {
            using (var transaction = this.context.Database.BeginTransaction())
            { 
                this.context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Categories ON");

                Categories category = new Categories()
                {
                    creation_user = CategorySave.creation_user,
                    creation_date = CategorySave.creation_date,
                    categoryname = CategorySave.categoryname,
                    description = CategorySave.description,
                    categoryid = CategorySave.categoryid



                };
                this.context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Categories OFF");

                transaction.Commit();
                this.context.Categories.Add(category);
                this.context.SaveChanges();

               

            }

            

            
        }




        public void UpdateCategory(CategoryUpdateModel CategoryUpdate)
        {
            var existingCategory = this.context.Categories.Find(CategoryUpdate.categoryid);

            if (existingCategory == null)
            {
                throw new KeyNotFoundException("Categoría no encontrada.");
            }


            existingCategory.categoryname = CategoryUpdate.categoryname;
            existingCategory.modify_user = CategoryUpdate.modify_user;
            existingCategory.modify_date = DateTime.Now;
            existingCategory.categoryid = CategoryUpdate.categoryid;


            this.context.Categories.Update(existingCategory);
            this.context.SaveChanges();
        }




        public void RemoveCategory(CategoryRemoveModel CategoryRemove)
        {
            var categoryToDelete = context.Categories.Find(CategoryRemove.deleted);


            categoryToDelete.deleted = true;
            categoryToDelete.delete_date = DateTime.Now;
            categoryToDelete.delete_user = CategoryRemove.delete_user;

            this.context.Categories.Update(categoryToDelete);
            this.context.SaveChanges();

        }
    }
}
