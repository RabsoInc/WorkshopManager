using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkshopManager.Models.CustomerRelationshipManagement.ViewModels;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Web.Controllers.CustomerRelationshipManagement
{
    [AllowAnonymous]
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork db;

        public CustomerController(IUnitOfWork db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //Handle the redirect
            ControllerViewMapping view = db.ControllerViewMappingRepository
                .GetSingleRecord(x => x.Controller == "Customer" && x.Action == "Index");

            //Create the display model
            CustomerIndexViewModel model = new();
            model.NewCustomer = new();
            model.AllCustomers = db.CustomerRepository.GetAllRecords();

            //Handle the drop downs
            ViewBag.Titles = db.TitleRepository.GenerateDropDowns();
            ViewBag.Genders = db.GenderRepository.GenerateDropDowns();

            return View(view.Path, model);
        }

        [HttpPost]
        public IActionResult Create(CustomerIndexViewModel model)
        {
            //Create the new customer
            model.NewCustomer.Id = Guid.NewGuid();
            db.CustomerRepository.CreateRecord(model.NewCustomer);
            db.UpdateDatabase();

            return RedirectToAction("Index");
        }
    }
}
