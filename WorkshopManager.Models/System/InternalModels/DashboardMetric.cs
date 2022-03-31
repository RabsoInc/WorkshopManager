using System.ComponentModel.DataAnnotations;

namespace WorkshopManager.Models.System.InternalModels
{
    public class DashboardMetric
    {
        [Required]
        public string Text { get; set; }

        [Required]
        public string Value { get; set; }
    }
}
