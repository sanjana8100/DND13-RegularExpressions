﻿namespace DND13_RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------User Registration----------");
            Console.WriteLine();

            UserRegistration userRegistration = new UserRegistration();

            Console.Write("Enter First Name: ");
            String firstName = Console.ReadLine();
            userRegistration.ValidateFirstName(firstName);

            Console.Write("Enter Last Name: ");
            String lastName = Console.ReadLine();
            userRegistration.ValidateLastName(lastName);
        }
    }
}