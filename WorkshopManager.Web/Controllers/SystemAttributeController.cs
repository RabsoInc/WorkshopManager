using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkshopManager.Models.System.ViewModels;
using WorkshopManager.Repository.IRepository;
using WorkshopManager.Support.Mapcodes;

namespace WorkshopManager.Web.Controllers
{
    [AllowAnonymous]
    public class SystemAttributeController : Controller
    {
        private readonly IUnitOfWork db;

        public SystemAttributeController(IUnitOfWork db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Manage(Guid id)
        {
            SystemAttributeViewModel model = new()
            {
                SystemAttribute = id == Guid.Empty ? new() : db.SystemAttributeRepository.GetSingleRecord(x => x.Id == id),
                SystemAttributes = db.SystemAttributeRepository.GetAllRecords().OrderBy(x => x.AttributeName)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Manage(SystemAttributeViewModel model)
        {
            if (model.SystemAttribute.Id == Guid.Empty)
            {
                model.SystemAttribute.Id = Guid.NewGuid();
                model.SystemAttribute.Mapcode = ManageMapcodes.GenerateNewMapcode("SA", model.SystemAttribute.AttributeName);
                db.SystemAttributeRepository.CreateRecord(model.SystemAttribute);
            }
            else
            {
                db.SystemAttributeRepository.UpdateRecord(model.SystemAttribute);
            }
            db.UpdateDatabase();
            return RedirectToAction("Manage", "SystemAttribute", new { id = Guid.Empty });
        }
    }
}

