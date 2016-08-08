using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyJourney.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public virtual IEnumerable<Advertisement> Advertisements { get; set; }
    }
}
