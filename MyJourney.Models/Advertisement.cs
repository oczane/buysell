using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyJourney.Models
{
    public class Advertisement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        public int Views { get; set; }

        public virtual User User { get; set; }
    }
}
