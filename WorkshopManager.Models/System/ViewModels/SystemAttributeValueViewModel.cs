using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.Models.System.ViewModels
{
    public class SystemAttributeValueViewModel
    {
        public SystemAttributeValue SystemAttributeValue { get; set; }
        public IEnumerable<SystemAttributeValue> SystemAttributeValues { get; set; }
    }
}
