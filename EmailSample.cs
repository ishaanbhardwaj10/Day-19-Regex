using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class EmailSample
    {
        public static string RegexRules = @"^[A-Za-z0-9+.-]{3,}[@][A_Za-z0-9]+[.][a-z]{2,}([.][a-z]{2})?$";
        public static bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
