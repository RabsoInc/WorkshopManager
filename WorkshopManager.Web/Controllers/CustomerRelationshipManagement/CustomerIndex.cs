using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkshopManager.Models.CustomerRelationshipManagement.ViewModels;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Web.Controllers.CustomerRelationshipManagement
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
            ControllerViewMapping view = db.ControllerViewMappingRepository
                .GetSingleRecord(x => x.Controller == "Customer" && x.Action == "Index");
            CustomerIndexViewModel model = new();
            model.NewCustomer = new();
            model.AllCustomers = db.CustomerRepository.GetAllRecords();
            return View(view.Path, model);
        }

        [HttpPost]
        public IActionResult Create(CustomerIndexViewModel model)
        {
            ControllerViewMapping view = db.ControllerViewMappingRepository
                .GetSingleRecord(x => x.Controller == "Customer" && x.Action == "Index");
            return View(view.Path);
        }
    }
}
