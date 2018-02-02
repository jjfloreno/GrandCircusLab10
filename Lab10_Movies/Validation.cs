using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace Lab10_Movies
{
    public class Validation
    {
        public static bool Category(string input)
        {
            if (Regex.Match(input,"^[1234]{1}$").Success)
            {
                return true;
            }
            else
                return false;
        }

        public static bool Continue(string input)
        {
            if (Regex.Match(input, "^[yn]$").Success)
            {
                return true;
            }
            else
                return false;
        }
    }
}
