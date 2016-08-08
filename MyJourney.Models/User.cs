using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace MyJourney.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string MobileNumber { get; set; }
        [Required]
        [MaxLength(10)]
        public string Password { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public virtual IEnumerable<Advertisement> Advertisements { get; set; }
    }
}
