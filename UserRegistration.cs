using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DND13_RegularExpressions
{
    internal class UserRegistration
    {
        public void ValidateFirstName(string firstName)
        {
            Regex firstNamePattern = new Regex("^[A-Z][a-z]{3,}$");
            Match firstNameMatcher = firstNamePattern.Match(firstName);

            if (firstNameMatcher.Success)
            {
                Console.WriteLine("-----Valid First Name");
            }
            else
            {
                Console.WriteLine("-----Invalid First Name");
            }
            Console.WriteLine();
        }

        public void ValidateLastName(string lastName)
        {
            Regex lastNamePattern = new Regex("^[A-Z][a-z]{3,}$");
            Match lastNameMatcher = lastNamePattern.Match(lastName);

            if (lastNameMatcher.Success)
            {
                Console.WriteLine("-----Valid Last Name");
            }
            else
            {
                Console.WriteLine("-----Invalid Last Name");
            }
            Console.WriteLine();
        }
    }
}
