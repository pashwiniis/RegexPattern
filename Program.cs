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
            Console.ReadKey();
        }
    }
}