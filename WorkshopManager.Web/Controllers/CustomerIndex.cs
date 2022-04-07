using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkshopManager.Models.CustomerRelationshipManagement.ViewModels;
using WorkshopManager.Repository.IRepository;

namespace WorkshopManager.Web.Controllers
{
    [AllowAnonymous]
    public class Customer : Controller
    {
        private readonly IUnitOfWork db;

        public Customer(IUnitOfWork db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CustomerIndexViewModel model = new();
            model.NewCustomer = new();
            model.AllCustomers = db.CustomerRepository.GetAllRecords();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CustomerIndexViewModel model)
        {
            //Customer x = model.NewCustomer();

            return View("Index");
        }
    }
}
