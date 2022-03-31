using System.ComponentModel.DataAnnotations;

namespace WorkshopManager.Models.System.BaseModels
{
    public class ReleaseNote
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(10)]
        public string ReleaseVersion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string ReleaseDate { get; set; }

        [Required]
        public string ReleaseNoteDetails { get; set; }
    }
}
