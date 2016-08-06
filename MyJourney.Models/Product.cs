using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJourney.Models
{
    public class Product : C_Name
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Manufacturer { get; set; }
        public string SKU { get; set; }
    }
}
