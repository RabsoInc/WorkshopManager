using System.ComponentModel.DataAnnotations;

namespace WorkshopManager.Models.System.BaseModels
{
    public class Title
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
