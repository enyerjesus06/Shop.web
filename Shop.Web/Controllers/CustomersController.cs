using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.CustomersModels;

namespace Shop.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomersDb customersDb;
        public CustomersController(ICustomersDb CustomersDb) 
        {
            this.customersDb = CustomersDb;
        }
        // GET: CustomersController
        public ActionResult Index()
        {
            var customers = customersDb.GetCustomers();
            return View(customers);
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            var customer = customersDb.GetCustomer(id);
            return View(customer);
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomersAddModel customerAdd)
        {
            
            
                customerAdd.custid = customerAdd.custid + 1;
                
                this.customersDb.SaveCustomer(customerAdd);
          
                return RedirectToAction(nameof(Index));
            
            
            
                
            
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = this.customersDb.GetCustomer(id);

            return View();
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomersUpdateModel customersUpdate)
        {
            
            
                customersUpdate.modify_date = DateTime.Now;
                customersUpdate.modify_user = 1;
                customersUpdate.contactname = customersUpdate.contactname;
                customersUpdate.custid = customersUpdate.custid;
            
                
            this.customersDb.UpdateCustomer(customersUpdate);
                return RedirectToAction(nameof(Index));
            
            
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View();
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
