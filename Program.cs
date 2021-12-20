using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPattern
{
    class program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.validateFirstName("Ashwini"));
            Console.WriteLine(patterns.validateLastName("Patil"));
            Console.WriteLine(patterns.validateEmailId("abc.xyz@bl.co.in"));
            Console.WriteLine(patterns.validateMobileFormatt("91 7567849345"));
            Console.WriteLine(patterns.validatePassword("Ashwini8"));
            Console.ReadKey();
        }
    }
}