using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Models.System.ViewModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Web.Controllers.System
{
    [AllowAnonymous]
    public class TitleController : Controller
    {
        private readonly IUnitOfWork db;

        public TitleController(IUnitOfWork db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Manage(Guid id)
        {
            ControllerViewMapping view = db.ControllerViewMappingRepository
                .GetSingleRecord(x => x.Controller == "Title" && x.Action == "Manage");
            TitleViewModel model = new();
            model.AllTitles = db.TitleRepository.GetAllRecords().OrderBy(x => x.Description);
            model.ManageTitle = id == Guid.Empty ? new() : db.TitleRepository.GetSingleRecord(x => x.Id == id);
            return View(view.Path, model);
        }

        [HttpPost]
        public IActionResult Manage(TitleViewModel model)
        {
            ControllerViewMapping view = db.ControllerViewMappingRepository
                .GetSingleRecord(x => x.Controller == "Title" && x.Action == "Manage");

            if (model.ManageTitle.Id == Guid.Empty)
            {
                model.ManageTitle.Id = Guid.NewGuid();
                db.TitleRepository.CreateRecord(model.ManageTitle);
            }
            else
            {
                db.TitleRepository.UpdateRecord(model.ManageTitle);
            }
            db.UpdateDatabase();
            return RedirectToAction("Manage");
        }
    }
}
