using System.ComponentModel.DataAnnotations;

namespace WorkshopManager.Models.System.BaseModels
{
    public class ControllerViewMapping
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Controller { get; set; }

        [Required]
        public string Action { get; set; }

        [Required]
        public string Path { get; set; }
    }
}
