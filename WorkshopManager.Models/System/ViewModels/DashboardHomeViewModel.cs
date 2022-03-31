using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Models.System.InternalModels;

namespace WorkshopManager.Models.System.ViewModels
{
    public class DashboardHomeViewModel
    {
        public ReleaseNote ReleaseNote { get; set; }
        public IEnumerable<DashboardMetric> DashboardMetrics { get; set; }
    }
}
