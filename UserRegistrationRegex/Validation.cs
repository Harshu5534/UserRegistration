using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Validation
    {
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public string ValidateFirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, FIRSTNAME_REGEX))
            {
                Console.WriteLine("First Name Matches");
            }
            else
            {
                Console.WriteLine("Verify First Name Again");
            }
            return firstname;
        }
        public string ValidateLastName(string lastname)
        {
            if (Regex.IsMatch(lastname, FIRSTNAME_REGEX))
            {
                Console.WriteLine("Last Name Matches");
            }
            else
            {
                Console.WriteLine("Verify Last Name Again");
            }
            return lastname;
        }

    }
}