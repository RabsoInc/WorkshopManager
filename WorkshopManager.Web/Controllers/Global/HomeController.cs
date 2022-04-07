using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkshopManager.Models.System.ViewModels;
using WorkshopManager.Repository.IRepository.Global;
using WorkshopManager.Support.Dashboard;

namespace WorkshopManager.Web.Controllers.Global
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork db;

        public HomeController(IUnitOfWork db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            DashboardHomeViewModel model = new DashboardHomeViewModel();
            model.ReleaseNote = db.ReleaseNoteRepository.GetLatestReleaseNote();
            model.DashboardMetrics = Metrics.ReturnMetrics();
            return View(model);
        }
    }
}