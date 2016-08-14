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

        public static string PrettyTitle(this string inputString)
        {
            if (inputString.Length > 22)
                return inputString.Substring(0, 22) + "...";

            return inputString;
        }

        public static string PrettyUserName(this string inputstring)
        {
            string[] rawString = inputstring.Split('|');
            return rawString[0].ToString();
        }
    }
}
