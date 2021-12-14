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
            public static string Regex_FirstName = "^[A-Z]{1}[a-z]{3,}$";
             public static string Regex_LastName = "^[A-Z]{1}[a-z]{3,}$";
            public bool validateFirstName(string FirstName)
            {
                return Regex.IsMatch(FirstName, Regex_FirstName);
                
            }
        public bool validateLastName(string LastName)
        {
            
            return Regex.IsMatch(LastName, Regex_LastName);
        }
    }
    
}
