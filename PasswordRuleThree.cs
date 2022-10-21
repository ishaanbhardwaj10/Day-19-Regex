using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class PasswordRuleThree
    {
        //using lookarounds: positive lookahead ?=
        public static string RegexRules = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public static bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
