using System.ComponentModel.DataAnnotations;

namespace WorkshopManager.Models.System.BaseModels
{
    public class Gender
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Gender")]
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
