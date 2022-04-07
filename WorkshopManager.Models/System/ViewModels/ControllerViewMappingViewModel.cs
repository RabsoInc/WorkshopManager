using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.Models.System.ViewModels
{
    public class ControllerViewMappingViewModel
    {
        public IEnumerable<ControllerViewMapping> AllControllerViewMappings { get; set; }
        public ControllerViewMapping ManageControllerViewMapping { get; set; }
    }
}
