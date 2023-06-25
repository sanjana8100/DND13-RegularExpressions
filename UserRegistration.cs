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

        public void ValidateEmail(string email)
        {
            Regex emailPattern = new Regex("^[0-9a-zA-Z]+([.]([a-z0-9A-Z]+))*[@][a-zA-Z]+[.][a-z]{2,4}([.][a-z]{2})?$");
            Match emailMatcher = emailPattern.Match(email);

            if (emailMatcher.Success)
            {
                Console.WriteLine("-----Valid Email Address");
            }
            else
            {
                Console.WriteLine("-----Invalid Email Address");
            }
            Console.WriteLine();
        }

        public void ValidatePhoneNumber(string phoneNumber)
        {
            Regex phoneNumberPattern = new Regex("^[+]{1}[0-9]{2}\\s[0-9]{10}$");
            Match phoneNumberMatcher = phoneNumberPattern.Match(phoneNumber);

            if (phoneNumberMatcher.Success)
            {
                Console.WriteLine("-----Valid Phone Number");
            }
            else
            {
                Console.WriteLine("-----Invalid Phone Number");
            }
            Console.WriteLine();
        }
    }
}
