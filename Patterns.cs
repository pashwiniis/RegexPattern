using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
        class Patterns
        {
            public static string Regex_UserRegestration = "^[A-Z]{1}[a-z]{3,}$";
           
            public bool validateFirstName(string FirstName)
            {
                return Regex.IsMatch(FirstName, Regex_UserRegestration);
            }
        }
    
}
