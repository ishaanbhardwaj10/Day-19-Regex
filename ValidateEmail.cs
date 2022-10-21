using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class ValidateEmail
    {
        public static string RegexRules = "^[A-Za-z0-9]+([._#][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
        public static bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
