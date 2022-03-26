using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WorkshopManager.Models.System.BaseModels
{
    public class SystemAttribute
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Attribute Name")]
        public string AttributeName{ get; set; }

        [Required]
        [MaxLength(125)]
        [Display(Name = "Map Code")]
        [ValidateNever]
        public string MapCode { get; set; }
    }
}
