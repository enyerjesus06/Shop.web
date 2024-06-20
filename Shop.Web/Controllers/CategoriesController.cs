using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CategoryModels;

namespace Shop.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesDb categoriesDb;
        public CategoriesController(ICategoriesDb CategoriesDb) 
        {
            this.categoriesDb = CategoriesDb;
        
        }
        // GET: CategoriesController
        public ActionResult Index()
        {
            var categories = categoriesDb.GetCategories();
            return View(categories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            var category = categoriesDb.GetCategory(id);
            return View(category);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryAddModel addModel)
        {




            addModel.categoryid = addModel.categoryid ++;
                this.categoriesDb.SaveCategory(addModel);
                return RedirectToAction(nameof(Index));
            
           
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            var category = categoriesDb.GetCategory(id);
            return View(category);
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryUpdateModel categoryUpdate)
        {
            try
            {
                categoryUpdate.modify_user = 1;
                categoryUpdate.modify_date = DateTime.Now;
                categoryUpdate.categoryid = categoryUpdate.categoryid + 1;
                
                this.categoriesDb.UpdateCategory(categoryUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}