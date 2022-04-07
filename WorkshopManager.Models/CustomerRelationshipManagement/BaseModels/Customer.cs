﻿using System.ComponentModel.DataAnnotations;

namespace WorkshopManager.Models.CustomerRelationshipManagement.BaseModels
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }
    }
}
