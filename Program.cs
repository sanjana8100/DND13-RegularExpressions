namespace DND13_RegularExpressions
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

            Console.Write("Enter Email Address: ");
            String email = Console.ReadLine();
            userRegistration.ValidateEmail(email);

            Console.Write("Enter Phone Number: ");
            String phoneNumber = Console.ReadLine();
            userRegistration.ValidatePhoneNumber(phoneNumber);

            Console.Write("Enter Password: ");
            String password = Console.ReadLine();
            userRegistration.ValidatePassword(password);
        }
    }
}