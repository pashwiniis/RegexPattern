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
            public static string Regex_EmailId  = "^[a-z0-9]+(.[a-z0-9]+)?@[a-z]+[.][a-z]{2,3}(.[a-z]{2})?$";
            public static string Regex_MobileFormatt = "^[1-9][0-9]{1,2}[ ][0-9]{10}$";
            public static string Regex_Password = "(?=.*[A-Z])[a-zA-Z0-9]{8,}$";
        public bool validateFirstName(string FirstName)
            {
                return Regex.IsMatch(FirstName, Regex_FirstName);
                
            }
        public bool validateLastName(string LastName)
        {
            
            return Regex.IsMatch(LastName, Regex_LastName);
        }
        public bool validateEmailId(string emailid)
        {

            return Regex.IsMatch(emailid, Regex_EmailId);
        }
        public bool validateMobileFormatt(string MobileNumber)
        {

            return Regex.IsMatch(MobileNumber, Regex_MobileFormatt);
        }
        public bool validatePassword(string password)
        {

            return Regex.IsMatch(password, Regex_Password);
        }

    }
    
}
