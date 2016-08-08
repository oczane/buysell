using System;
using System.ComponentModel.DataAnnotations;

namespace MyJourney.Models
{
    public class VisitorLog
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public DateTime Created { get; set; }
    }
}
