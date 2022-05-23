using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Validation
    {                                                                                                       
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public const string LASTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public static string PASSWORD_REGEX = "^[#@%!]{1}+[a-zA-z0-9]{8,}$";
        private string message;

        public Validation(string message)
        {
            this.message = message;
        }
        public bool ValidateFirstName(string firstname) => Regex.IsMatch(firstname, FIRSTNAME_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_FIRSTNAME, "First Name Is Invalid");
        public bool ValidateLastName(string lastname) => Regex.IsMatch(lastname, LASTNAME_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_LASTNAME, "Last Name Is Invalid");
        public bool ValidateEmail(string email) => Regex.IsMatch(email, EMAIL_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_EMAIL, "Email Is Invalid");
        public bool ValidateMobileNumber(string mobileNumber) => Regex.IsMatch(mobileNumber, MOBILENUMBER_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_MOBILENUMBER, "Mobile Number Is Invalid");
        public bool ValidatePassword(string password) => Regex.IsMatch(password, PASSWORD_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_PASSWORD, "Password Is Invalid");
        public bool ValidateEmailParametrized(string email) => Regex.IsMatch(email, EMAIL_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_EMAIL, "Email Is Invalid");

    }
}