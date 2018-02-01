using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab10_Movies
{
    class Validation
    {
        public static bool Category(string input, string choice1, string choice2, string choice3, string choice4)
        {
            if (input == choice1 || input == choice2 || input == choice3 || input == choice4)
            {
                return true;
            }
            else
                return false;
        }
        //try enums for the same method as above
        //public static bool ValidateCategoryEnum(string userinput, enum Choices)
        //{

        //}
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
