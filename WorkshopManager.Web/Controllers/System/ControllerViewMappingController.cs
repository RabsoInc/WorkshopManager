using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkshopManager.Models.System.ViewModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Web.Controllers.System
{
    [AllowAnonymous]
    public class ControllerViewMappingController : Controller
    {
        private readonly IUnitOfWork db;
        private readonly IConfiguration config;


        public ControllerViewMappingController(IUnitOfWork db, IConfiguration config)
        {
            this.db = db;
            this.config = config;
        }

        [HttpGet]
        public IActionResult Manage(Guid id)
        {
            string defaultPath = config.GetValue<string>("ControllerViewMapping:Default");
            ControllerViewMappingViewModel model = new();
            model.AllControllerViewMappings = db.ControllerViewMappingRepository
                .GetAllRecords()
                .OrderBy(x => x.Controller)
                .ThenBy(x => x.Action);
            model.ManageControllerViewMapping = id == Guid.Empty ? new() : db.ControllerViewMappingRepository.GetSingleRecord(x => x.Id == id);
            return View(defaultPath, model);
        }

        [HttpPost]
        public IActionResult Manage(ControllerViewMappingViewModel model)
        {
            string defaultPath = config.GetValue<string>("ControllerViewMapping:Default");
            if (model.ManageControllerViewMapping.Id == Guid.Empty)
            {
                //Create
                model.ManageControllerViewMapping.Id = Guid.NewGuid();
                db.ControllerViewMappingRepository.CreateRecord(model.ManageControllerViewMapping);
            }
            else
            {
                db.ControllerViewMappingRepository.UpdateRecord(model.ManageControllerViewMapping);
            }
            db.UpdateDatabase();
            return RedirectToAction("Manage");
        }
    }
}
