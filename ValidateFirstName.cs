using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class ValidateFirstName
    {
        public static string RegexRules = "^[A-Z]{1}[a-z]{2,}$";
        public static bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }

    }
}
