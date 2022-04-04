using System.ComponentModel.DataAnnotations;

namespace WorkshopManager.Models.System.BaseModels
{
    public class SystemAttributeValue
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "System Attribute Value")]
        public string AttributeValue { get; set; }

        [Required]
        public Guid SystemAttributeId { get; set; }

        //Navigation properties
        public SystemAttribute SystemAttribute { get; set; }
    }
}
