using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJourney.Models.Helpers
{
    public static class Extension
    {
        public static string Pretty(this string inputString)
        {
            return inputString.Trim().Replace(" ", "-");
        }
    }
}
