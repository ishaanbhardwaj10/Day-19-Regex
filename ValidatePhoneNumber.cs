using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class ValidatePhoneNumber
    {
        /* for indian phone numbers: country code "91" followed by a whitespace and a 10 digit number
        starting from 6,7,8 or 9 */

        public static string RegexRules = "^[9][1][ ][6-9][0-9]{9}$";
        public static bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }

    }
}
