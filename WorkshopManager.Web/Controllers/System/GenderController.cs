using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Models.System.ViewModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Web.Controllers.System
{
    [AllowAnonymous]
    public class GenderController : Controller
    {
        private readonly IUnitOfWork db;

        public GenderController(IUnitOfWork db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Manage(Guid id)
        {
            ControllerViewMapping view = db.ControllerViewMappingRepository
                .GetSingleRecord(x => x.Controller == "Gender" && x.Action == "Manage");
            GenderViewModel model = new();
            model.AllGenders = db.GenderRepository.GetAllRecords().OrderBy(x => x.Description);
            model.ManageGender = id == Guid.Empty ? new() : db.GenderRepository.GetSingleRecord(x => x.Id == id);
            return View(view.Path, model);
        }

        [HttpPost]
        public IActionResult Manage(GenderViewModel model)
        {
            ControllerViewMapping view = db.ControllerViewMappingRepository
                .GetSingleRecord(x => x.Controller == "Gender" && x.Action == "Manage");

            if (model.ManageGender.Id == Guid.Empty)
            {
                model.ManageGender.Id = Guid.NewGuid();
                db.GenderRepository.CreateRecord(model.ManageGender);
            }
            else
            {
                db.GenderRepository.UpdateRecord(model.ManageGender);
            }
            db.UpdateDatabase();
            return RedirectToAction("Manage");
        }
    }
}
