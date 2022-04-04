using System.ComponentModel.DataAnnotations;
using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.Models.System.ViewModels
{
    public class SystemAttributeViewModel
    {
        [Required]
        public SystemAttribute SystemAttribute { get; set; }
        [Required]
        public IEnumerable<SystemAttribute> SystemAttributes { get; set; }
    }
}
