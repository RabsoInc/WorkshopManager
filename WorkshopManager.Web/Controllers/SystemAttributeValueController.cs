using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WorkshopManager.Models.System.ViewModels;
using WorkshopManager.Repository.IRepository;

namespace WorkshopManager.Web.Controllers
{
    [AllowAnonymous]
    public class SystemAttributeValueController : Controller
    {
        private readonly IUnitOfWork db;

        public SystemAttributeValueController(IUnitOfWork db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Manage(Guid id)
        {
            SystemAttributeValueViewModel model = new();
            model.SystemAttributeValues = db.SystemAttributeValueRepository.GetAllRecords("SystemAttribute");
            model.SystemAttributeValue = id == Guid.Empty ? new() : db.SystemAttributeValueRepository.GetSingleRecord(x => x.Id == id);
            ViewBag.SystemAttributes = new SelectList(db.SystemAttributeRepository.GetAllRecords(), "Id", "AttributeName");
            return View(model);
        }

        [HttpPost]
        public IActionResult Manage(SystemAttributeValueViewModel model)
        {
            if (model.SystemAttributeValue.Id == Guid.Empty)
            {
                model.SystemAttributeValue.Id = Guid.NewGuid();
                db.SystemAttributeValueRepository.CreateRecord(model.SystemAttributeValue);
            }
            else
            {
                db.SystemAttributeValueRepository.UpdateRecord(model.SystemAttributeValue);
            }
            db.UpdateDatabase();
            return RedirectToAction("Manage", "SystemAttributeValue", new { id = Guid.Empty });
        }
    }
}